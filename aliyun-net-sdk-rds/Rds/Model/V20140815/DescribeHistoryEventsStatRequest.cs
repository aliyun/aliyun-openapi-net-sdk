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
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeHistoryEventsStatRequest : RpcAcsRequest<DescribeHistoryEventsStatResponse>
    {
        public DescribeHistoryEventsStatRequest()
            : base("Rds", "2014-08-15", "DescribeHistoryEventsStat", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string toStartTime;

		private string securityToken;

		private string fromStartTime;

		private string archiveStatus;

		[JsonProperty(PropertyName = "ToStartTime")]
		public string ToStartTime
		{
			get
			{
				return toStartTime;
			}
			set	
			{
				toStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ToStartTime", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "FromStartTime")]
		public string FromStartTime
		{
			get
			{
				return fromStartTime;
			}
			set	
			{
				fromStartTime = value;
				DictionaryUtil.Add(QueryParameters, "FromStartTime", value);
			}
		}

		[JsonProperty(PropertyName = "ArchiveStatus")]
		public string ArchiveStatus
		{
			get
			{
				return archiveStatus;
			}
			set	
			{
				archiveStatus = value;
				DictionaryUtil.Add(QueryParameters, "ArchiveStatus", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeHistoryEventsStatResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeHistoryEventsStatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
