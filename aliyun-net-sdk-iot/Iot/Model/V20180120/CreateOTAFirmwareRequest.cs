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
    public class CreateOTAFirmwareRequest : RpcAcsRequest<CreateOTAFirmwareResponse>
    {
        public CreateOTAFirmwareRequest()
            : base("Iot", "2018-01-20", "CreateOTAFirmware", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string signMethod;

		private bool? needToVerify;

		private int? type;

		private string firmwareUrl;

		private string iotInstanceId;

		private string firmwareDesc;

		private string moduleName;

		private string firmwareSign;

		private int? firmwareSize;

		private string firmwareName;

		private string productKey;

		private string srcVersion;

		private string destVersion;

		public string SignMethod
		{
			get
			{
				return signMethod;
			}
			set	
			{
				signMethod = value;
				DictionaryUtil.Add(QueryParameters, "SignMethod", value);
			}
		}

		public bool? NeedToVerify
		{
			get
			{
				return needToVerify;
			}
			set	
			{
				needToVerify = value;
				DictionaryUtil.Add(QueryParameters, "NeedToVerify", value.ToString());
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public string FirmwareUrl
		{
			get
			{
				return firmwareUrl;
			}
			set	
			{
				firmwareUrl = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareUrl", value);
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

		public string FirmwareDesc
		{
			get
			{
				return firmwareDesc;
			}
			set	
			{
				firmwareDesc = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareDesc", value);
			}
		}

		public string ModuleName
		{
			get
			{
				return moduleName;
			}
			set	
			{
				moduleName = value;
				DictionaryUtil.Add(QueryParameters, "ModuleName", value);
			}
		}

		public string FirmwareSign
		{
			get
			{
				return firmwareSign;
			}
			set	
			{
				firmwareSign = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareSign", value);
			}
		}

		public int? FirmwareSize
		{
			get
			{
				return firmwareSize;
			}
			set	
			{
				firmwareSize = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareSize", value.ToString());
			}
		}

		public string FirmwareName
		{
			get
			{
				return firmwareName;
			}
			set	
			{
				firmwareName = value;
				DictionaryUtil.Add(QueryParameters, "FirmwareName", value);
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

		public string SrcVersion
		{
			get
			{
				return srcVersion;
			}
			set	
			{
				srcVersion = value;
				DictionaryUtil.Add(QueryParameters, "SrcVersion", value);
			}
		}

		public string DestVersion
		{
			get
			{
				return destVersion;
			}
			set	
			{
				destVersion = value;
				DictionaryUtil.Add(QueryParameters, "DestVersion", value);
			}
		}

        public override CreateOTAFirmwareResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOTAFirmwareResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
