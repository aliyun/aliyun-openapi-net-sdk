/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;

namespace Aliyun.Acs.Core.Exceptions
{
    public class ClientException : Exception
    {
        public String ErrorCode { get; set; }

        public String ErrorMessage { get; set; }

        public string RequestId { get; set; }

        public ErrorType ErrorType { get; set; }

        public ClientException(String errCode, String errMsg, string requestId)
            : this(errCode, errMsg)
        {

        }

        public ClientException(String errCode, String errMsg)
            : base(errCode + " : " + errMsg)
        {
            ErrorCode = errCode;
            ErrorMessage = errMsg;
            ErrorType = ErrorType.Client;
        }

        public ClientException(String message)
            : base(message)
        {

        }
    }
}
