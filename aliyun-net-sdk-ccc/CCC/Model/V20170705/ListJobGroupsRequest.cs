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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ListJobGroupsRequest : RpcAcsRequest<ListJobGroupsResponse>
    {
        public ListJobGroupsRequest()
            : base("CCC", "2017-07-05", "ListJobGroups", "ccc", "openAPI")
        {
        }

        private string instanceId;

        private int? pageSize;

        private long? endTime;

        private long? startTime;

        private int? pageNumber;

        public string InstanceId
        {
            get
            {
                return instanceId;
            }
            set
            {
                instanceId = value;
                DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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
                DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
            }
        }

        public long? EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
                DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
            }
        }

        public long? StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
                DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
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
                DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
            }
        }

        public override bool CheckShowJsonItemName()
        {
            return false;
        }

        public override ListJobGroupsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListJobGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}