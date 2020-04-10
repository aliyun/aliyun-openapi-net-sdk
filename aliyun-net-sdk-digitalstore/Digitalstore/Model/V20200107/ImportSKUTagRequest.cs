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
    public class ImportSKUTagRequest : RpcAcsRequest<ImportSKUTagResponse>
    {
        public ImportSKUTagRequest()
            : base("digitalstore", "2020-01-07", "ImportSKUTag", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string tagValue;

		private string uniqueCode;

		private string tid;

		private string flowNumber;

		private string warehouseCode;

		private string barcode;

		public string TagValue
		{
			get
			{
				return tagValue;
			}
			set	
			{
				tagValue = value;
				DictionaryUtil.Add(BodyParameters, "TagValue", value);
			}
		}

		public string UniqueCode
		{
			get
			{
				return uniqueCode;
			}
			set	
			{
				uniqueCode = value;
				DictionaryUtil.Add(BodyParameters, "UniqueCode", value);
			}
		}

		public string Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(BodyParameters, "Tid", value);
			}
		}

		public string FlowNumber
		{
			get
			{
				return flowNumber;
			}
			set	
			{
				flowNumber = value;
				DictionaryUtil.Add(BodyParameters, "FlowNumber", value);
			}
		}

		public string WarehouseCode
		{
			get
			{
				return warehouseCode;
			}
			set	
			{
				warehouseCode = value;
				DictionaryUtil.Add(BodyParameters, "WarehouseCode", value);
			}
		}

		public string Barcode
		{
			get
			{
				return barcode;
			}
			set	
			{
				barcode = value;
				DictionaryUtil.Add(BodyParameters, "Barcode", value);
			}
		}

        public override ImportSKUTagResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportSKUTagResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
