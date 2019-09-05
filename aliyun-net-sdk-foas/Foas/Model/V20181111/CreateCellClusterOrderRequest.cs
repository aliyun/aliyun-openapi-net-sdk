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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class CreateCellClusterOrderRequest : RoaAcsRequest<CreateCellClusterOrderResponse>
    {
        public CreateCellClusterOrderRequest()
            : base("foas", "2018-11-11", "CreateCellClusterOrder", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/realtime-compute/cell/buy";
			Method = MethodType.POST;
        }

		private int? period;

		private int? slaveNum;

		private string slaveSpec;

		private string region;

		private int? masterNum;

		private string masterSpec;

		private string payModel;

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(BodyParameters, "period", value.ToString());
			}
		}

		public int? SlaveNum
		{
			get
			{
				return slaveNum;
			}
			set	
			{
				slaveNum = value;
				DictionaryUtil.Add(BodyParameters, "slaveNum", value.ToString());
			}
		}

		public string SlaveSpec
		{
			get
			{
				return slaveSpec;
			}
			set	
			{
				slaveSpec = value;
				DictionaryUtil.Add(BodyParameters, "slaveSpec", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(BodyParameters, "region", value);
			}
		}

		public int? MasterNum
		{
			get
			{
				return masterNum;
			}
			set	
			{
				masterNum = value;
				DictionaryUtil.Add(BodyParameters, "masterNum", value.ToString());
			}
		}

		public string MasterSpec
		{
			get
			{
				return masterSpec;
			}
			set	
			{
				masterSpec = value;
				DictionaryUtil.Add(BodyParameters, "masterSpec", value);
			}
		}

		public string PayModel
		{
			get
			{
				return payModel;
			}
			set	
			{
				payModel = value;
				DictionaryUtil.Add(BodyParameters, "payModel", value);
			}
		}

        public override CreateCellClusterOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCellClusterOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
