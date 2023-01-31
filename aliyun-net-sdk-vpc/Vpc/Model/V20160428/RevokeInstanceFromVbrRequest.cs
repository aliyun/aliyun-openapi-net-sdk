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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class RevokeInstanceFromVbrRequest : RpcAcsRequest<RevokeInstanceFromVbrResponse>
    {
        public RevokeInstanceFromVbrRequest()
            : base("Vpc", "2016-04-28", "RevokeInstanceFromVbr", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string vbrOwnerUid;

		private string vbrRegionNo;

		private List<string> vbrInstanceIds = new List<string>(){ };

		private string grantType;

		private string instanceId;

		public string VbrOwnerUid
		{
			get
			{
				return vbrOwnerUid;
			}
			set	
			{
				vbrOwnerUid = value;
				DictionaryUtil.Add(QueryParameters, "VbrOwnerUid", value);
			}
		}

		public string VbrRegionNo
		{
			get
			{
				return vbrRegionNo;
			}
			set	
			{
				vbrRegionNo = value;
				DictionaryUtil.Add(QueryParameters, "VbrRegionNo", value);
			}
		}

		public List<string> VbrInstanceIds
		{
			get
			{
				return vbrInstanceIds;
			}

			set
			{
				vbrInstanceIds = value;
				if(vbrInstanceIds != null)
				{
					for (int depth1 = 0; depth1 < vbrInstanceIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"VbrInstanceIds." + (depth1 + 1), vbrInstanceIds[depth1]);
					}
				}
			}
		}

		public string GrantType
		{
			get
			{
				return grantType;
			}
			set	
			{
				grantType = value;
				DictionaryUtil.Add(QueryParameters, "GrantType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RevokeInstanceFromVbrResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RevokeInstanceFromVbrResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
