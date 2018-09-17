---
title: Event Sourcing
description: Overview of Event Sourcing
keywords: Overview, Domain Events, Event Sourcing, Event Store, Log
author: smithmx
---
The key words “MUST”, “MUST NOT”, “REQUIRED”, “SHALL”, “SHALL NOT”, “SHOULD”, “SHOULD NOT”,
“RECOMMENDED”, “MAY”, and “OPTIONAL” in this document are to be interpreted as described in
[RFC 2119](https://tools.ietf.org/html/rfc2119).

## Definition

Event Sourcing is an approach that derives the current state of an application from the sequential, incemental changes (events) that have
happened within the application. 

## Managing State

While it is a fringe approach for maintaining state within application development, it has a long history within mature business domains, especially where there is a requirement to have a cast-iron audit log (e.g. finance/accounting).  The traditional approach to managing state involves storing the current state of a particular record (in a database table or document).  This may be supplemented by an audit table that records changes in the data for the particular entity.  The source of truth is the current state in the table, not the audit log. 

Event Sourcing rather than storing the current state, stores the changes / deltas in the form of immutable events in the seqeuence that they happened.  It is then possible to derive the state of any particular entity be replaying all the changes that have happened to this entity.  In an event sourced system the event log and current state are one in the same.  There is no possibility that they can be out of synch (and there is no possibility that your log is incorrect).  By explicitly capturing and recording state changes (deltas) as Events (see Domain Events), we can know how and why our system is in the state it is.  This can bring enormous business value to the business (see The Business Value of the Event Log).

## An immutable log

The Event Store is an *immutable, append-only log* that is the single authoritative source of truth for the system.  

Events are facts and Event Sourcing is based on the incremental accretion of knoweldge about our application / domain.  Events in the log **cannot be changed**.  They **cannot be deleted**.  They represent things that have happened. Thus, in the absence of a time machine, they cannot be made to un-happen.  To negate the effect of an Event that has happened, it is necessary for another Event to occur that reverses the effect.  This can be clearly seen in the Accounting domain where the Ledger is an immutable event store or journal.  Entries in the ledger cannot be changed.  The current balance can be derived at any point but accumulating all the changes (entries) that have been made and summing the pluses and minuses,

Where a mistake has been made, a new entry in the ledger is made with an adjustment (plus or minus) to correct the mistake.  Where a mistake is made in the correction, you similarly cannot change the correction.  You must make another entry to correct the correct, and so on.  Thus we have a definitive and irrefutable record of the state of the system.  An Event Sourced system not only knows the current state of the system, it knows how we arrived at that state.  Furthermore, it knows the state of the system at any point in time and can also tell us what the state should have been compared to what we thought it was at any particular point in time.  *Blockchain* operates on the same immutable ledger principles as an Event Store.

## Don't throw away information

By capturing all changes in the forms of deltas (persisted Events) and modelling the why of the change (in the form of the Event itself), and Event Sourced system does not throw away information.  It does not assume that we know all the information that is or will be useful in the future at the current time.  In a traditional system that captures only the current state, only explicitly captured state can be interrogated.  If we wish to test a hypothesis, it is often necessary to make a change to the production system to capture new state, wait enough time to gather sufficient data and then test our hypothesis.  In an Event Sourced system, it is often the case that the hypothesis can be tested just by interrogating the events.

The oft-cited example of this is in the e-shopping domain and the theory that a user who has an item in their shopping cart but does not proceed to buy it will be more likely to buy this item in the future.  The traditional approach that, at best, captures only the state of the shopping cart and at worst only captures orders, cannot test this hypothesis at all.  If we do not know how the shopping cart changed, we do not know who added the item then removed it.  We do not know who emptied their cart of all items.  We might be able to tell what was in a cart that failed to convert to an order.

On the other hand, in an Event Sourced system where we have **ItemAddedToCart** and **ItemRemovedFromCart** events, we can look back in time and check exactly how many people who had an item in their cart at some point and did not buy it, subsequently did.  This requires no change to the production system and no time to wait to gather sufficicent data.

An Event Sourced system does not assume that we know the business value of all the data that the system generates for now and all time or that we always make well informed decisions for what data to keep and what to discard.

Of course, if the data is not captured in an Event or if several distinct things we would like to know are captured and folded into a single event, then that data may be lost (or only inferred rather than explicitly known).

## Single source of truth, multiple views

The append only log of events is the single source of truth in an Event Sourced system. The events are persisted in serialized form.

The Event Store defines how the events are written in the system, it does not define or prescribe how things are read or interpreted.  Events will be published from the Event Store and can be handled by subscribers to these events.  These subscribers can then process the events in any way they require.  A typical scenario will involve updating a materialized (cached) view in a CQRS system.  Another will be to populate the data for a Machine Learning algorithm or to feed data to an OLAP cube.  It might feed into a relational database or a graph database.  The subscribers and what they do will be determined by the requirements of the system.  The Event Sourced nature of the system imposes no limits on the subscribers / read side of the system beyond that the Event Store is the single source of truth.
