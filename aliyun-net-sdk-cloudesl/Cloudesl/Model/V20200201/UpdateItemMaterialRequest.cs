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
    public class UpdateItemMaterialRequest : RpcAcsRequest<UpdateItemMaterialResponse>
    {
        public UpdateItemMaterialRequest()
            : base("cloudesl", "2020-02-01", "UpdateItemMaterial")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string materialId;

		private string barCode;

		private string itemName;

		private string materialFeatureA;

		private string materialFeatureB;

		private string materialFeatureC;

		private string materialFeatureD;

		public string MaterialId
		{
			get
			{
				return materialId;
			}
			set	
			{
				materialId = value;
				DictionaryUtil.Add(BodyParameters, "MaterialId", value);
			}
		}

		public string BarCode
		{
			get
			{
				return barCode;
			}
			set	
			{
				barCode = value;
				DictionaryUtil.Add(BodyParameters, "BarCode", value);
			}
		}

		public string ItemName
		{
			get
			{
				return itemName;
			}
			set	
			{
				itemName = value;
				DictionaryUtil.Add(BodyParameters, "ItemName", value);
			}
		}

		public string MaterialFeatureA
		{
			get
			{
				return materialFeatureA;
			}
			set	
			{
				materialFeatureA = value;
				DictionaryUtil.Add(BodyParameters, "MaterialFeatureA", value);
			}
		}

		public string MaterialFeatureB
		{
			get
			{
				return materialFeatureB;
			}
			set	
			{
				materialFeatureB = value;
				DictionaryUtil.Add(BodyParameters, "MaterialFeatureB", value);
			}
		}

		public string MaterialFeatureC
		{
			get
			{
				return materialFeatureC;
			}
			set	
			{
				materialFeatureC = value;
				DictionaryUtil.Add(BodyParameters, "MaterialFeatureC", value);
			}
		}

		public string MaterialFeatureD
		{
			get
			{
				return materialFeatureD;
			}
			set	
			{
				materialFeatureD = value;
				DictionaryUtil.Add(BodyParameters, "MaterialFeatureD", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateItemMaterialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateItemMaterialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
