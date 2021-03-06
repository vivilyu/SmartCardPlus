﻿using System;

namespace PCSC
{
    /// <summary>
    /// The smart card is unpowered.
    /// </summary>
    public class UnpoweredCardException : PCSCException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnpoweredCardException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        public UnpoweredCardException(SCardError serr)
            : base(serr) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="UnpoweredCardException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        /// <param name="message">An error message text.</param>
        public UnpoweredCardException(SCardError serr, string message)
            : base(serr, message) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="UnpoweredCardException"/> class.
        /// </summary>
        /// <param name="serr">System's error code</param>
        /// <param name="message">An error message text.</param>
        /// <param name="innerException">The inner exception.</param>
        public UnpoweredCardException(SCardError serr, string message, Exception innerException)
            : base(serr, message, innerException) {}
    }
}
