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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20190801;

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
    public class ConfirmLogisticsRequest : RpcAcsRequest<ConfirmLogisticsResponse>
    {
        public ConfirmLogisticsRequest()
            : base("cloudesl", "2019-08-01", "ConfirmLogistics", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string prNumber;

		private string logisticsDocuments;

		private string poNumber;

		private string status;

		public string PrNumber
		{
			get
			{
				return prNumber;
			}
			set	
			{
				prNumber = value;
				DictionaryUtil.Add(BodyParameters, "PrNumber", value);
			}
		}

		public string LogisticsDocuments
		{
			get
			{
				return logisticsDocuments;
			}
			set	
			{
				logisticsDocuments = value;
				DictionaryUtil.Add(BodyParameters, "LogisticsDocuments", value);
			}
		}

		public string PoNumber
		{
			get
			{
				return poNumber;
			}
			set	
			{
				poNumber = value;
				DictionaryUtil.Add(BodyParameters, "PoNumber", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

        public override ConfirmLogisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfirmLogisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
