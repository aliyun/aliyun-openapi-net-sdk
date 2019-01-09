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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class FindImagesRequest : RpcAcsRequest<FindImagesResponse>
    {
        public FindImagesRequest()
            : base("imm", "2017-09-06", "FindImages", "2017-09-06", "openAPI")
        {
        }

		private string gender;

		private string remarksAPrefix;

		private string project;

		private string orderBy;

		private string imageSizeRange;

		private string remarksBPrefix;

		private string tagNames;

		private string accessKeyId;

		private string sourceUriPrefix;

		private string locationBoundary;

		private string emotion;

		private string imageTimeRange;

		private string marker;

		private string oCRContentsMatch;

		private string createTimeRange;

		private string action;

		private string setId;

		private string sourceType;

		private string updateTimeRange;

		private string ageRange;

		private string order;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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

		public string UpdateTimeRange
		{
			get
			{
				return updateTimeRange;
			}
			set	
			{
				updateTimeRange = value;
				DictionaryUtil.Add(QueryParameters, "UpdateTimeRange", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FindImagesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return FindImagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}