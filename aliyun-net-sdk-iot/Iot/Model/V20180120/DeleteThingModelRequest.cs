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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class DeleteThingModelRequest : RpcAcsRequest<DeleteThingModelResponse>
    {
        public DeleteThingModelRequest()
            : base("Iot", "2018-01-20", "DeleteThingModel", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private List<string> propertyIdentifiers = new List<string>(){ };

		private string iotInstanceId;

		private List<string> serviceIdentifiers = new List<string>(){ };

		private string productKey;

		private List<string> eventIdentifiers = new List<string>(){ };

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public List<string> PropertyIdentifiers
		{
			get
			{
				return propertyIdentifiers;
			}

			set
			{
				propertyIdentifiers = value;
				for (int i = 0; i < propertyIdentifiers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PropertyIdentifier." + (i + 1) , propertyIdentifiers[i]);
				}
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public List<string> ServiceIdentifiers
		{
			get
			{
				return serviceIdentifiers;
			}

			set
			{
				serviceIdentifiers = value;
				for (int i = 0; i < serviceIdentifiers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ServiceIdentifier." + (i + 1) , serviceIdentifiers[i]);
				}
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public List<string> EventIdentifiers
		{
			get
			{
				return eventIdentifiers;
			}

			set
			{
				eventIdentifiers = value;
				for (int i = 0; i < eventIdentifiers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EventIdentifier." + (i + 1) , eventIdentifiers[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteThingModelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteThingModelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
