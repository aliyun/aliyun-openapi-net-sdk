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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeGrantRulesToCenResponse : AcsResponse
    {

        private string requestId;

        private int? totalCount;

        private int? pageNumber;

        private int? pageSize;

        private List<DescribeGrantRulesToCen_CbnGrantRule> cenGrantRules;

        public string RequestId
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

        public int? TotalCount
        {
            get
            {
                return totalCount;
            }
            set
            {
                totalCount = value;
            }
        }

        public int? PageNumber
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public int? PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }

        public List<DescribeGrantRulesToCen_CbnGrantRule> CenGrantRules
        {
            get
            {
                return cenGrantRules;
            }
            set
            {
                cenGrantRules = value;
            }
        }

        public class DescribeGrantRulesToCen_CbnGrantRule
        {

            private string cenInstanceId;

            private long? cenOwnerId;

            private string creationTime;

            public string CenInstanceId
            {
                get
                {
                    return cenInstanceId;
                }
                set
                {
                    cenInstanceId = value;
                }
            }

            public long? CenOwnerId
            {
                get
                {
                    return cenOwnerId;
                }
                set
                {
                    cenOwnerId = value;
                }
            }

            public string CreationTime
            {
                get
                {
                    return creationTime;
                }
                set
                {
                    creationTime = value;
                }
            }
        }
    }
}