﻿namespace Bam.Testing.Specification
{
    public class ThenAction
    {
        public string Description { get; set; }
        public Action<ThenDelegate> Action { get; set; }
    }
}
