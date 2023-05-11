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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class PictureSearchPictureRequest : RpcAcsRequest<PictureSearchPictureResponse>
    {
        public PictureSearchPictureRequest()
            : base("Linkvisual", "2018-01-20", "PictureSearchPicture", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? threshold;

		private string searchPicUrl;

		private long? startTime;

		private int? pictureSearchType;

		private int? pageSize;

		private long? endTime;

		private int? currentPage;

		private bool? containPicUrl;

		private string appInstanceId;

		public float? Threshold
		{
			get
			{
				return threshold;
			}
			set	
			{
				threshold = value;
				DictionaryUtil.Add(QueryParameters, "Threshold", value.ToString());
			}
		}

		public string SearchPicUrl
		{
			get
			{
				return searchPicUrl;
			}
			set	
			{
				searchPicUrl = value;
				DictionaryUtil.Add(QueryParameters, "SearchPicUrl", value);
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public int? PictureSearchType
		{
			get
			{
				return pictureSearchType;
			}
			set	
			{
				pictureSearchType = value;
				DictionaryUtil.Add(QueryParameters, "PictureSearchType", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public bool? ContainPicUrl
		{
			get
			{
				return containPicUrl;
			}
			set	
			{
				containPicUrl = value;
				DictionaryUtil.Add(QueryParameters, "ContainPicUrl", value.ToString());
			}
		}

		public string AppInstanceId
		{
			get
			{
				return appInstanceId;
			}
			set	
			{
				appInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "AppInstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PictureSearchPictureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PictureSearchPictureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
