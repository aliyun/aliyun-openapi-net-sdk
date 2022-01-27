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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class GetOfficePreviewURLRequest : RpcAcsRequest<GetOfficePreviewURLResponse>
    {
        public GetOfficePreviewURLRequest()
            : base("imm", "2017-09-06", "GetOfficePreviewURL", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string srcType;

		private string project;

		private int? watermarkVertical;

		private int? watermarkType;

		private float? watermarkRotate;

		private string watermarkValue;

		private string watermarkFont;

		private int? watermarkHorizontal;

		private string srcUri;

		private string watermarkFillStyle;

		public string SrcType
		{
			get
			{
				return srcType;
			}
			set	
			{
				srcType = value;
				DictionaryUtil.Add(QueryParameters, "SrcType", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public int? WatermarkVertical
		{
			get
			{
				return watermarkVertical;
			}
			set	
			{
				watermarkVertical = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkVertical", value.ToString());
			}
		}

		public int? WatermarkType
		{
			get
			{
				return watermarkType;
			}
			set	
			{
				watermarkType = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkType", value.ToString());
			}
		}

		public float? WatermarkRotate
		{
			get
			{
				return watermarkRotate;
			}
			set	
			{
				watermarkRotate = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkRotate", value.ToString());
			}
		}

		public string WatermarkValue
		{
			get
			{
				return watermarkValue;
			}
			set	
			{
				watermarkValue = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkValue", value);
			}
		}

		public string WatermarkFont
		{
			get
			{
				return watermarkFont;
			}
			set	
			{
				watermarkFont = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkFont", value);
			}
		}

		public int? WatermarkHorizontal
		{
			get
			{
				return watermarkHorizontal;
			}
			set	
			{
				watermarkHorizontal = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkHorizontal", value.ToString());
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
				DictionaryUtil.Add(QueryParameters, "SrcUri", value);
			}
		}

		public string WatermarkFillStyle
		{
			get
			{
				return watermarkFillStyle;
			}
			set	
			{
				watermarkFillStyle = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkFillStyle", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetOfficePreviewURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetOfficePreviewURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
