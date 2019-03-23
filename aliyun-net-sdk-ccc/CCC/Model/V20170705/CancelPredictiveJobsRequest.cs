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
    public class CancelPredictiveJobsRequest : RpcAcsRequest<CancelPredictiveJobsResponse>
    {
        public CancelPredictiveJobsRequest()
            : base("CCC", "2017-07-05", "CancelPredictiveJobs", "ccc", "openAPI")
        {
        }

        private bool? all;

        private List<string> jobIds;

        private string instanceId;

        private string jobGroupId;

        public bool? All
        {
            get
            {
                return all;
            }
            set
            {
                all = value;
                DictionaryUtil.Add(QueryParameters, "All", value.ToString());
            }
        }

        public List<string> JobIds
        {
            get
            {
                return jobIds;
            }

            set
            {
                jobIds = value;
                for (int i = 0; i < jobIds.Count; i++)
                {
                    DictionaryUtil.Add(QueryParameters, "JobId." + (i + 1), jobIds[i]);
                }
            }
        }

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

        public string JobGroupId
        {
            get
            {
                return jobGroupId;
            }
            set
            {
                jobGroupId = value;
                DictionaryUtil.Add(QueryParameters, "JobGroupId", value);
            }
        }

        public override bool CheckShowJsonItemName()
        {
            return false;
        }

        public override CancelPredictiveJobsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CancelPredictiveJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}