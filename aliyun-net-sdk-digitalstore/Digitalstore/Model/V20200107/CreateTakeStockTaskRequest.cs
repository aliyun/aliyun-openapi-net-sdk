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
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class CreateTakeStockTaskRequest : RpcAcsRequest<CreateTakeStockTaskResponse>
    {
        public CreateTakeStockTaskRequest()
            : base("digitalstore", "2020-01-07", "CreateTakeStockTask", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string deviceNumber;

		private string takeStockOrderId;

		public string DeviceNumber
		{
			get
			{
				return deviceNumber;
			}
			set	
			{
				deviceNumber = value;
				DictionaryUtil.Add(BodyParameters, "DeviceNumber", value);
			}
		}

		public string TakeStockOrderId
		{
			get
			{
				return takeStockOrderId;
			}
			set	
			{
				takeStockOrderId = value;
				DictionaryUtil.Add(BodyParameters, "TakeStockOrderId", value);
			}
		}

        public override CreateTakeStockTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTakeStockTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
