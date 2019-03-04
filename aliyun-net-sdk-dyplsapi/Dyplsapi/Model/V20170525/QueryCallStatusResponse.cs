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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class QueryCallStatusResponse : AcsResponse
    {

        private string requestId;

        private string code;

        private string message;

        private int? status;

        private string calledNo;

        private QueryCallStatus_SecretCallStatusDTO secretCallStatusDTO;

        public new string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public int? Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string CalledNo
        {
            get
            {
                return calledNo;
            }
            set
            {
                calledNo = value;
            }
        }

        public QueryCallStatus_SecretCallStatusDTO SecretCallStatusDTO
        {
            get
            {
                return secretCallStatusDTO;
            }
            set
            {
                secretCallStatusDTO = value;
            }
        }

        public class QueryCallStatus_SecretCallStatusDTO
        {

            private int? status;

            private string calledNo;

            public int? Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }


            public string CalledNo
            {
                get
                {
                    return calledNo;
                }
                set
                {
                    calledNo = value;
                }
            }
        }
    }
}
