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
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class EditEventRequest : RpcAcsRequest<EditEventResponse>
    {
        public EditEventRequest()
            : base("CloudPhoto", "2017-07-11", "EditEvent", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string eventId;

		private string bannerPhotoId;

		private string watermarkPhotoId;

		private string identity;

		private string splashPhotoId;

		private string libraryId;

		private string weixinTitle;

		private string storeName;

		private string remark;

		private string title;

		private long? endAt;

		private long? startAt;

		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
				DictionaryUtil.Add(QueryParameters, "EventId", value);
			}
		}

		public string BannerPhotoId
		{
			get
			{
				return bannerPhotoId;
			}
			set	
			{
				bannerPhotoId = value;
				DictionaryUtil.Add(QueryParameters, "BannerPhotoId", value);
			}
		}

		public string WatermarkPhotoId
		{
			get
			{
				return watermarkPhotoId;
			}
			set	
			{
				watermarkPhotoId = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkPhotoId", value);
			}
		}

		public string Identity
		{
			get
			{
				return identity;
			}
			set	
			{
				identity = value;
				DictionaryUtil.Add(QueryParameters, "Identity", value);
			}
		}

		public string SplashPhotoId
		{
			get
			{
				return splashPhotoId;
			}
			set	
			{
				splashPhotoId = value;
				DictionaryUtil.Add(QueryParameters, "SplashPhotoId", value);
			}
		}

		public string LibraryId
		{
			get
			{
				return libraryId;
			}
			set	
			{
				libraryId = value;
				DictionaryUtil.Add(QueryParameters, "LibraryId", value);
			}
		}

		public string WeixinTitle
		{
			get
			{
				return weixinTitle;
			}
			set	
			{
				weixinTitle = value;
				DictionaryUtil.Add(QueryParameters, "WeixinTitle", value);
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public long? EndAt
		{
			get
			{
				return endAt;
			}
			set	
			{
				endAt = value;
				DictionaryUtil.Add(QueryParameters, "EndAt", value.ToString());
			}
		}

		public long? StartAt
		{
			get
			{
				return startAt;
			}
			set	
			{
				startAt = value;
				DictionaryUtil.Add(QueryParameters, "StartAt", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EditEventResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return EditEventResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}