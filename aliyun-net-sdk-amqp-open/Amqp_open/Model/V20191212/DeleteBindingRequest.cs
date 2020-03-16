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
using Aliyun.Acs.amqp_open.Transform;
using Aliyun.Acs.amqp_open.Transform.V20191212;

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
    public class DeleteBindingRequest : RpcAcsRequest<DeleteBindingResponse>
    {
        public DeleteBindingRequest()
            : base("amqp-open", "2019-12-12", "DeleteBinding", "onsproxy", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string destinationName;

		private string sourceExchange;

		private string bindingKey;

		private string bindingType;

		private string instanceId;

		private string virtualHost;

		public string DestinationName
		{
			get
			{
				return destinationName;
			}
			set	
			{
				destinationName = value;
				DictionaryUtil.Add(BodyParameters, "DestinationName", value);
			}
		}

		public string SourceExchange
		{
			get
			{
				return sourceExchange;
			}
			set	
			{
				sourceExchange = value;
				DictionaryUtil.Add(BodyParameters, "SourceExchange", value);
			}
		}

		public string BindingKey
		{
			get
			{
				return bindingKey;
			}
			set	
			{
				bindingKey = value;
				DictionaryUtil.Add(BodyParameters, "BindingKey", value);
			}
		}

		public string BindingType
		{
			get
			{
				return bindingType;
			}
			set	
			{
				bindingType = value;
				DictionaryUtil.Add(BodyParameters, "BindingType", value);
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
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public string VirtualHost
		{
			get
			{
				return virtualHost;
			}
			set	
			{
				virtualHost = value;
				DictionaryUtil.Add(BodyParameters, "VirtualHost", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteBindingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteBindingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
