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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class CreateHbaseHaSlbRequest : RpcAcsRequest<CreateHbaseHaSlbResponse>
    {
        public CreateHbaseHaSlbRequest()
            : base("HBase", "2019-01-01", "CreateHbaseHaSlb", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string haTypes;

		private string hbaseType;

		private string bdsId;

		private string haId;

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

		public string HaTypes
		{
			get
			{
				return haTypes;
			}
			set	
			{
				haTypes = value;
				DictionaryUtil.Add(QueryParameters, "HaTypes", value);
			}
		}

		public string HbaseType
		{
			get
			{
				return hbaseType;
			}
			set	
			{
				hbaseType = value;
				DictionaryUtil.Add(QueryParameters, "HbaseType", value);
			}
		}

		public string BdsId
		{
			get
			{
				return bdsId;
			}
			set	
			{
				bdsId = value;
				DictionaryUtil.Add(QueryParameters, "BdsId", value);
			}
		}

		public string HaId
		{
			get
			{
				return haId;
			}
			set	
			{
				haId = value;
				DictionaryUtil.Add(QueryParameters, "HaId", value);
			}
		}

        public override CreateHbaseHaSlbResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateHbaseHaSlbResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
