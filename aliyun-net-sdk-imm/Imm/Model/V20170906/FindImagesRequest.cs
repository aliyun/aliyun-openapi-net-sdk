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
    public class FindImagesRequest : RpcAcsRequest<FindImagesResponse>
    {
        public FindImagesRequest()
            : base("imm", "2017-09-06", "FindImages", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string remarksArrayBIn;

		private string project;

		private string externalId;

		private string facesModifyTimeRange;

		private string oCRContentsMatch;

		private int? limit;

		private string remarksDPrefix;

		private string sourceType;

		private string order;

		private string groupId;

		private string orderBy;

		private string tagNames;

		private string marker;

		private string remarksCPrefix;

		private string modifyTimeRange;

		private string addressLineContentsMatch;

		private string gender;

		private string remarksArrayAIn;

		private string imageSizeRange;

		private string remarksBPrefix;

		private string locationBoundary;

		private string imageTimeRange;

		private string tagsModifyTimeRange;

		private string ageRange;

		private string remarksAPrefix;

		private string sourceUriPrefix;

		private string emotion;

		private string createTimeRange;

		private string setId;

		public string RemarksArrayBIn
		{
			get
			{
				return remarksArrayBIn;
			}
			set	
			{
				remarksArrayBIn = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayBIn", value);
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

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
				DictionaryUtil.Add(QueryParameters, "ExternalId", value);
			}
		}

		public string FacesModifyTimeRange
		{
			get
			{
				return facesModifyTimeRange;
			}
			set	
			{
				facesModifyTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "FacesModifyTimeRange", value);
			}
		}

		public string OCRContentsMatch
		{
			get
			{
				return oCRContentsMatch;
			}
			set	
			{
				oCRContentsMatch = value;
				DictionaryUtil.Add(QueryParameters, "OCRContentsMatch", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string RemarksDPrefix
		{
			get
			{
				return remarksDPrefix;
			}
			set	
			{
				remarksDPrefix = value;
				DictionaryUtil.Add(QueryParameters, "RemarksDPrefix", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string TagNames
		{
			get
			{
				return tagNames;
			}
			set	
			{
				tagNames = value;
				DictionaryUtil.Add(QueryParameters, "TagNames", value);
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
				DictionaryUtil.Add(QueryParameters, "Marker", value);
			}
		}

		public string RemarksCPrefix
		{
			get
			{
				return remarksCPrefix;
			}
			set	
			{
				remarksCPrefix = value;
				DictionaryUtil.Add(QueryParameters, "RemarksCPrefix", value);
			}
		}

		public string ModifyTimeRange
		{
			get
			{
				return modifyTimeRange;
			}
			set	
			{
				modifyTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "ModifyTimeRange", value);
			}
		}

		public string AddressLineContentsMatch
		{
			get
			{
				return addressLineContentsMatch;
			}
			set	
			{
				addressLineContentsMatch = value;
				DictionaryUtil.Add(QueryParameters, "AddressLineContentsMatch", value);
			}
		}

		public string Gender
		{
			get
			{
				return gender;
			}
			set	
			{
				gender = value;
				DictionaryUtil.Add(QueryParameters, "Gender", value);
			}
		}

		public string RemarksArrayAIn
		{
			get
			{
				return remarksArrayAIn;
			}
			set	
			{
				remarksArrayAIn = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayAIn", value);
			}
		}

		public string ImageSizeRange
		{
			get
			{
				return imageSizeRange;
			}
			set	
			{
				imageSizeRange = value;
				DictionaryUtil.Add(QueryParameters, "ImageSizeRange", value);
			}
		}

		public string RemarksBPrefix
		{
			get
			{
				return remarksBPrefix;
			}
			set	
			{
				remarksBPrefix = value;
				DictionaryUtil.Add(QueryParameters, "RemarksBPrefix", value);
			}
		}

		public string LocationBoundary
		{
			get
			{
				return locationBoundary;
			}
			set	
			{
				locationBoundary = value;
				DictionaryUtil.Add(QueryParameters, "LocationBoundary", value);
			}
		}

		public string ImageTimeRange
		{
			get
			{
				return imageTimeRange;
			}
			set	
			{
				imageTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "ImageTimeRange", value);
			}
		}

		public string TagsModifyTimeRange
		{
			get
			{
				return tagsModifyTimeRange;
			}
			set	
			{
				tagsModifyTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "TagsModifyTimeRange", value);
			}
		}

		public string AgeRange
		{
			get
			{
				return ageRange;
			}
			set	
			{
				ageRange = value;
				DictionaryUtil.Add(QueryParameters, "AgeRange", value);
			}
		}

		public string RemarksAPrefix
		{
			get
			{
				return remarksAPrefix;
			}
			set	
			{
				remarksAPrefix = value;
				DictionaryUtil.Add(QueryParameters, "RemarksAPrefix", value);
			}
		}

		public string SourceUriPrefix
		{
			get
			{
				return sourceUriPrefix;
			}
			set	
			{
				sourceUriPrefix = value;
				DictionaryUtil.Add(QueryParameters, "SourceUriPrefix", value);
			}
		}

		public string Emotion
		{
			get
			{
				return emotion;
			}
			set	
			{
				emotion = value;
				DictionaryUtil.Add(QueryParameters, "Emotion", value);
			}
		}

		public string CreateTimeRange
		{
			get
			{
				return createTimeRange;
			}
			set	
			{
				createTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeRange", value);
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
				DictionaryUtil.Add(QueryParameters, "SetId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FindImagesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FindImagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
