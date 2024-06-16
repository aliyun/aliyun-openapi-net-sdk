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
using Aliyun.Acs.nis.Transform;
using Aliyun.Acs.nis.Transform.V20211216;

namespace Aliyun.Acs.nis.Model.V20211216
{
    public class DeleteNetworkPathRequest : RpcAcsRequest<DeleteNetworkPathResponse>
    {
        public DeleteNetworkPathRequest()
            : base("nis", "2021-12-16", "DeleteNetworkPath", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private List<string> networkPathIds = new List<string>(){ };

		[JsonProperty(PropertyName = "NetworkPathIds")]
		public List<string> NetworkPathIds
		{
			get
			{
				return networkPathIds;
			}

			set
			{
				networkPathIds = value;
				if(networkPathIds != null)
				{
					for (int depth1 = 0; depth1 < networkPathIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"NetworkPathIds." + (depth1 + 1), networkPathIds[depth1]);
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteNetworkPathResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteNetworkPathResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
