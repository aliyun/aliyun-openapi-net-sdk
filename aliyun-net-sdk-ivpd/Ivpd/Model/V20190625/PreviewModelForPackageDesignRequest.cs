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
using Aliyun.Acs.ivpd.Transform;
using Aliyun.Acs.ivpd.Transform.V20190625;

namespace Aliyun.Acs.ivpd.Model.V20190625
{
    public class PreviewModelForPackageDesignRequest : RpcAcsRequest<PreviewModelForPackageDesignResponse>
    {
        public PreviewModelForPackageDesignRequest()
            : base("ivpd", "2019-06-25", "PreviewModelForPackageDesign", "ivpd", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string materialName;

		private List<ElementList> elementLists = new List<ElementList>(){ };

		private string dataId;

		private string materialType;

		private string modelType;

		private string category;

		public string MaterialName
		{
			get
			{
				return materialName;
			}
			set	
			{
				materialName = value;
				DictionaryUtil.Add(BodyParameters, "MaterialName", value);
			}
		}

		public List<ElementList> ElementLists
		{
			get
			{
				return elementLists;
			}

			set
			{
				elementLists = value;
				for (int i = 0; i < elementLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ElementList." + (i + 1) + ".ImageUrl", elementLists[i].ImageUrl);
					DictionaryUtil.Add(BodyParameters,"ElementList." + (i + 1) + ".SideName", elementLists[i].SideName);
				}
			}
		}

		public string DataId
		{
			get
			{
				return dataId;
			}
			set	
			{
				dataId = value;
				DictionaryUtil.Add(BodyParameters, "DataId", value);
			}
		}

		public string MaterialType
		{
			get
			{
				return materialType;
			}
			set	
			{
				materialType = value;
				DictionaryUtil.Add(BodyParameters, "MaterialType", value);
			}
		}

		public string ModelType
		{
			get
			{
				return modelType;
			}
			set	
			{
				modelType = value;
				DictionaryUtil.Add(BodyParameters, "ModelType", value);
			}
		}

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(BodyParameters, "Category", value);
			}
		}

		public class ElementList
		{

			private string imageUrl;

			private string sideName;

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			public string SideName
			{
				get
				{
					return sideName;
				}
				set	
				{
					sideName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PreviewModelForPackageDesignResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PreviewModelForPackageDesignResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
