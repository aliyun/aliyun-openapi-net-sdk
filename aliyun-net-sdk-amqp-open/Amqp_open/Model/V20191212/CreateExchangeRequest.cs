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
    public class CreateExchangeRequest : RpcAcsRequest<CreateExchangeResponse>
    {
        public CreateExchangeRequest()
            : base("amqp-open", "2019-12-12", "CreateExchange", "onsproxy", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? _internal;

		private string exchangeName;

		private string instanceId;

		private string alternateExchange;

		private bool? autoDeleteState;

		private string exchangeType;

		private string virtualHost;

		public bool? _Internal
		{
			get
			{
				return _internal;
			}
			set	
			{
				_internal = value;
				DictionaryUtil.Add(BodyParameters, "Internal", value.ToString());
			}
		}

		public string ExchangeName
		{
			get
			{
				return exchangeName;
			}
			set	
			{
				exchangeName = value;
				DictionaryUtil.Add(BodyParameters, "ExchangeName", value);
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

		public string AlternateExchange
		{
			get
			{
				return alternateExchange;
			}
			set	
			{
				alternateExchange = value;
				DictionaryUtil.Add(BodyParameters, "AlternateExchange", value);
			}
		}

		public bool? AutoDeleteState
		{
			get
			{
				return autoDeleteState;
			}
			set	
			{
				autoDeleteState = value;
				DictionaryUtil.Add(BodyParameters, "AutoDeleteState", value.ToString());
			}
		}

		public string ExchangeType
		{
			get
			{
				return exchangeType;
			}
			set	
			{
				exchangeType = value;
				DictionaryUtil.Add(BodyParameters, "ExchangeType", value);
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

        public override CreateExchangeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateExchangeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
