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
using Aliyun.Acs.videoenhan.Transform;
using Aliyun.Acs.videoenhan.Transform.V20200320;

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
    public class MergeVideoModelFaceRequest : RpcAcsRequest<MergeVideoModelFaceResponse>
    {
        public MergeVideoModelFaceRequest()
            : base("videoenhan", "2020-03-20", "MergeVideoModelFace", "videoenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string faceImageURL;

		private List<string> mergeInfoss = new List<string>(){ };

		private bool? enhance;

		private string templateId;

		private bool? addWatermark;

		public string FaceImageURL
		{
			get
			{
				return faceImageURL;
			}
			set	
			{
				faceImageURL = value;
				DictionaryUtil.Add(BodyParameters, "FaceImageURL", value);
			}
		}

		public List<string> MergeInfoss
		{
			get
			{
				return mergeInfoss;
			}

			set
			{
				mergeInfoss = value;
				if(mergeInfoss != null)
				{
					for (int depth1 = 0; depth1 < mergeInfoss.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"MergeInfos." + (depth1 + 1), mergeInfoss[depth1]);
						DictionaryUtil.Add(BodyParameters,"MergeInfos." + (depth1 + 1), mergeInfoss[depth1]);
						DictionaryUtil.Add(BodyParameters,"MergeInfos." + (depth1 + 1), mergeInfoss[depth1]);
					}
				}
			}
		}

		public bool? Enhance
		{
			get
			{
				return enhance;
			}
			set	
			{
				enhance = value;
				DictionaryUtil.Add(BodyParameters, "Enhance", value.ToString());
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(BodyParameters, "TemplateId", value);
			}
		}

		public bool? AddWatermark
		{
			get
			{
				return addWatermark;
			}
			set	
			{
				addWatermark = value;
				DictionaryUtil.Add(BodyParameters, "AddWatermark", value.ToString());
			}
		}

		public class MergeInfos
		{

			private string templateFaceURL;

			private string imageURL;

			private string templateFaceID;

			public string TemplateFaceURL
			{
				get
				{
					return templateFaceURL;
				}
				set	
				{
					templateFaceURL = value;
				}
			}

			public string ImageURL
			{
				get
				{
					return imageURL;
				}
				set	
				{
					imageURL = value;
				}
			}

			public string TemplateFaceID
			{
				get
				{
					return templateFaceID;
				}
				set	
				{
					templateFaceID = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override MergeVideoModelFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MergeVideoModelFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
