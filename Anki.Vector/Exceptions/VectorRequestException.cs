﻿// <copyright file="VectorRequestException.cs" company="Wayne Venables">
//     Copyright (c) 2019 Wayne Venables. All rights reserved.
// </copyright>

using System;

namespace Anki.Vector.Exceptions
{
    /// <summary>
    /// Request to Vector has failed
    /// </summary>
    /// <seealso cref="Anki.Vector.Exceptions.VectorException" />
    public class VectorRequestException : VectorException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorRequestException"/> class.
        /// </summary>
        internal VectorRequestException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorRequestException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        internal VectorRequestException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorRequestException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        internal VectorRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
