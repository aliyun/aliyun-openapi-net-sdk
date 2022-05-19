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
using Aliyun.Acs.idaas_doraemon;
using Aliyun.Acs.idaas_doraemon.Transform;
using Aliyun.Acs.idaas_doraemon.Transform.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Model.V20210520
{
    public class ServiceInvokeRequest : RpcAcsRequest<ServiceInvokeResponse>
    {
        public ServiceInvokeRequest()
            : base("idaas-doraemon", "2021-05-20", "ServiceInvoke")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idaas_doraemon.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string xClientIp;

		private string mobileExtendParamsJsonSign;

		private string serverExtendParamsJson;

		private string doraemonAction;

		private string mobileExtendParamsJson;

		private string serviceCode;

		private bool? testModel;

		private string applicationExternalId;

		public string XClientIp
		{
			get
			{
				return xClientIp;
			}
			set	
			{
				xClientIp = value;
				DictionaryUtil.Add(QueryParameters, "XClientIp", value);
			}
		}

		public string MobileExtendParamsJsonSign
		{
			get
			{
				return mobileExtendParamsJsonSign;
			}
			set	
			{
				mobileExtendParamsJsonSign = value;
				DictionaryUtil.Add(QueryParameters, "MobileExtendParamsJsonSign", value);
			}
		}

		public string ServerExtendParamsJson
		{
			get
			{
				return serverExtendParamsJson;
			}
			set	
			{
				serverExtendParamsJson = value;
				DictionaryUtil.Add(QueryParameters, "ServerExtendParamsJson", value);
			}
		}

		public string DoraemonAction
		{
			get
			{
				return doraemonAction;
			}
			set	
			{
				doraemonAction = value;
				DictionaryUtil.Add(QueryParameters, "DoraemonAction", value);
			}
		}

		public string MobileExtendParamsJson
		{
			get
			{
				return mobileExtendParamsJson;
			}
			set	
			{
				mobileExtendParamsJson = value;
				DictionaryUtil.Add(QueryParameters, "MobileExtendParamsJson", value);
			}
		}

		public string ServiceCode
		{
			get
			{
				return serviceCode;
			}
			set	
			{
				serviceCode = value;
				DictionaryUtil.Add(QueryParameters, "ServiceCode", value);
			}
		}

		public bool? TestModel
		{
			get
			{
				return testModel;
			}
			set	
			{
				testModel = value;
				DictionaryUtil.Add(QueryParameters, "TestModel", value.ToString());
			}
		}

		public string ApplicationExternalId
		{
			get
			{
				return applicationExternalId;
			}
			set	
			{
				applicationExternalId = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationExternalId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ServiceInvokeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ServiceInvokeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
