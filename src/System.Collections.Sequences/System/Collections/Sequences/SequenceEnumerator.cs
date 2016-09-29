﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace System.Collections.Sequences
{
    public struct SequenceEnumerator<T>
    {
        Position _position;
        ISequence<T> _sequence;

        public SequenceEnumerator(ISequence<T> sequence)
        {
            _sequence = sequence;
            _position = Position.BeforeFirst;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            _sequence.GetAt(ref _position, advance: true);
            if (_position.IsValid && !_position.Equals(Position.AfterLast)) { 
            }
            return false;
        }

        public T Current {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return _sequence.GetAt(ref _position);
            }
        }
    }
}