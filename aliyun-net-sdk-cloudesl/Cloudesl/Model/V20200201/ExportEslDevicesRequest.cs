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
using Aliyun.Acs.cloudesl;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class ExportEslDevicesRequest : RpcAcsRequest<ExportEslDevicesResponse>
    {
        public ExportEslDevicesRequest()
            : base("cloudesl", "2020-02-01", "ExportEslDevices")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string language;

		private string type;

		private string storeId;

		private string eslBarCode;

		private string typeEncode;

		private string eslStatus;

		private int? toBatteryLevel;

		private string levelLower;

		private int? fromBatteryLevel;

		private string levelOrder;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
			}
		}

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(BodyParameters, "Language", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public string EslBarCode
		{
			get
			{
				return eslBarCode;
			}
			set	
			{
				eslBarCode = value;
				DictionaryUtil.Add(BodyParameters, "EslBarCode", value);
			}
		}

		public string TypeEncode
		{
			get
			{
				return typeEncode;
			}
			set	
			{
				typeEncode = value;
				DictionaryUtil.Add(BodyParameters, "TypeEncode", value);
			}
		}

		public string EslStatus
		{
			get
			{
				return eslStatus;
			}
			set	
			{
				eslStatus = value;
				DictionaryUtil.Add(BodyParameters, "EslStatus", value);
			}
		}

		public int? ToBatteryLevel
		{
			get
			{
				return toBatteryLevel;
			}
			set	
			{
				toBatteryLevel = value;
				DictionaryUtil.Add(BodyParameters, "ToBatteryLevel", value.ToString());
			}
		}

		public string LevelLower
		{
			get
			{
				return levelLower;
			}
			set	
			{
				levelLower = value;
				DictionaryUtil.Add(BodyParameters, "LevelLower", value);
			}
		}

		public int? FromBatteryLevel
		{
			get
			{
				return fromBatteryLevel;
			}
			set	
			{
				fromBatteryLevel = value;
				DictionaryUtil.Add(BodyParameters, "FromBatteryLevel", value.ToString());
			}
		}

		public string LevelOrder
		{
			get
			{
				return levelOrder;
			}
			set	
			{
				levelOrder = value;
				DictionaryUtil.Add(BodyParameters, "LevelOrder", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportEslDevicesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportEslDevicesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
