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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class CreateSasOrderRequest : RpcAcsRequest<CreateSasOrderResponse>
    {
        public CreateSasOrderRequest()
            : base("Sas", "2018-12-03", "CreateSasOrder", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sasWebguardBoolean;

		private bool? autoUseCoupon;

		private string spec;

		private string instanceCount;

		private string sasWebguardOrderNum;

		private string containerImageScan;

		private int? autoRenewPeriod;

		private int? period;

		private bool? autoPay;

		private string sasAntiRansomware;

		private string periodUnit;

		private string sasSc;

		private string vcore;

		private string sasSlsStorage;

		private string sasProductService;

		public string SasWebguardBoolean
		{
			get
			{
				return sasWebguardBoolean;
			}
			set	
			{
				sasWebguardBoolean = value;
				DictionaryUtil.Add(QueryParameters, "SasWebguardBoolean", value);
			}
		}

		public bool? AutoUseCoupon
		{
			get
			{
				return autoUseCoupon;
			}
			set	
			{
				autoUseCoupon = value;
				DictionaryUtil.Add(QueryParameters, "AutoUseCoupon", value.ToString());
			}
		}

		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
				DictionaryUtil.Add(QueryParameters, "Spec", value);
			}
		}

		public string InstanceCount
		{
			get
			{
				return instanceCount;
			}
			set	
			{
				instanceCount = value;
				DictionaryUtil.Add(QueryParameters, "InstanceCount", value);
			}
		}

		public string SasWebguardOrderNum
		{
			get
			{
				return sasWebguardOrderNum;
			}
			set	
			{
				sasWebguardOrderNum = value;
				DictionaryUtil.Add(QueryParameters, "SasWebguardOrderNum", value);
			}
		}

		public string ContainerImageScan
		{
			get
			{
				return containerImageScan;
			}
			set	
			{
				containerImageScan = value;
				DictionaryUtil.Add(QueryParameters, "ContainerImageScan", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public string SasAntiRansomware
		{
			get
			{
				return sasAntiRansomware;
			}
			set	
			{
				sasAntiRansomware = value;
				DictionaryUtil.Add(QueryParameters, "SasAntiRansomware", value);
			}
		}

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public string SasSc
		{
			get
			{
				return sasSc;
			}
			set	
			{
				sasSc = value;
				DictionaryUtil.Add(QueryParameters, "SasSc", value);
			}
		}

		public string Vcore
		{
			get
			{
				return vcore;
			}
			set	
			{
				vcore = value;
				DictionaryUtil.Add(QueryParameters, "Vcore", value);
			}
		}

		public string SasSlsStorage
		{
			get
			{
				return sasSlsStorage;
			}
			set	
			{
				sasSlsStorage = value;
				DictionaryUtil.Add(QueryParameters, "SasSlsStorage", value);
			}
		}

		public string SasProductService
		{
			get
			{
				return sasProductService;
			}
			set	
			{
				sasProductService = value;
				DictionaryUtil.Add(QueryParameters, "SasProductService", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSasOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSasOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
