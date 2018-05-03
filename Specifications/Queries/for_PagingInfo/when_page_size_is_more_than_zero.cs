﻿using Machine.Specifications;

namespace Dolittle.Queries.Specs.for_PagingInfo
{
    public class when_page_size_is_more_than_zero
    {
        static PagingInfo paging = new PagingInfo();

        Because of = () => paging.Size = 42;

        It should_not_have_paging_enabled = () => paging.Enabled.ShouldBeTrue();
    }
}