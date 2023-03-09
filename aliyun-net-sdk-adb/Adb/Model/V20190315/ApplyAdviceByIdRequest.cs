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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class ApplyAdviceByIdRequest : RpcAcsRequest<ApplyAdviceByIdResponse>
    {
        public ApplyAdviceByIdRequest()
            : base("adb", "2019-03-15", "ApplyAdviceById", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string adviceId;

		private string dBClusterId;

		private long? adviceDate;

		public string AdviceId
		{
			get
			{
				return adviceId;
			}
			set	
			{
				adviceId = value;
				DictionaryUtil.Add(QueryParameters, "AdviceId", value);
			}
		}

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public long? AdviceDate
		{
			get
			{
				return adviceDate;
			}
			set	
			{
				adviceDate = value;
				DictionaryUtil.Add(QueryParameters, "AdviceDate", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ApplyAdviceByIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyAdviceByIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
