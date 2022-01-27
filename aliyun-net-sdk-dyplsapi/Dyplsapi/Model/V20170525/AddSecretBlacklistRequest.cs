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
using Aliyun.Acs.Dyplsapi;
using Aliyun.Acs.Dyplsapi.Transform;
using Aliyun.Acs.Dyplsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class AddSecretBlacklistRequest : RpcAcsRequest<AddSecretBlacklistResponse>
    {
        public AddSecretBlacklistRequest()
            : base("Dyplsapi", "2017-05-25", "AddSecretBlacklist")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dyplsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dyplsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string blackType;

		private string remark;

		private string poolKey;

		private string blackNo;

		private string wayControl;

		public string BlackType
		{
			get
			{
				return blackType;
			}
			set	
			{
				blackType = value;
				DictionaryUtil.Add(QueryParameters, "BlackType", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string PoolKey
		{
			get
			{
				return poolKey;
			}
			set	
			{
				poolKey = value;
				DictionaryUtil.Add(QueryParameters, "PoolKey", value);
			}
		}

		public string BlackNo
		{
			get
			{
				return blackNo;
			}
			set	
			{
				blackNo = value;
				DictionaryUtil.Add(QueryParameters, "BlackNo", value);
			}
		}

		public string WayControl
		{
			get
			{
				return wayControl;
			}
			set	
			{
				wayControl = value;
				DictionaryUtil.Add(QueryParameters, "WayControl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddSecretBlacklistResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddSecretBlacklistResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
