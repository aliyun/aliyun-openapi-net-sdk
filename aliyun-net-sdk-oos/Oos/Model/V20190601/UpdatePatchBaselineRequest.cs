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
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class UpdatePatchBaselineRequest : RpcAcsRequest<UpdatePatchBaselineResponse>
    {
        public UpdatePatchBaselineRequest()
            : base("oos", "2019-06-01", "UpdatePatchBaseline", "oos", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.oos.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string approvalRules;

		private string description;

		private List<string> rejectedPatches = new List<string>(){ };

		private string rejectedPatchesAction;

		private string name;

		[JsonProperty(PropertyName = "ClientToken")]
		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		[JsonProperty(PropertyName = "ApprovalRules")]
		public string ApprovalRules
		{
			get
			{
				return approvalRules;
			}
			set	
			{
				approvalRules = value;
				DictionaryUtil.Add(QueryParameters, "ApprovalRules", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "RejectedPatches")]
		public List<string> RejectedPatches
		{
			get
			{
				return rejectedPatches;
			}

			set
			{
				rejectedPatches = value;
				if(rejectedPatches != null)
				{
					for (int depth1 = 0; depth1 < rejectedPatches.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RejectedPatches." + (depth1 + 1), rejectedPatches[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "RejectedPatchesAction")]
		public string RejectedPatchesAction
		{
			get
			{
				return rejectedPatchesAction;
			}
			set	
			{
				rejectedPatchesAction = value;
				DictionaryUtil.Add(QueryParameters, "RejectedPatchesAction", value);
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdatePatchBaselineResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdatePatchBaselineResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
