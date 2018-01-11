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
    public class RegisterPhotoRequest : RpcAcsRequest<RegisterPhotoResponse>
    {
        public RegisterPhotoRequest()
            : base("CloudPhoto", "2017-07-11", "RegisterPhoto", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string libraryId;

		private float? latitude;

		private string photoTitle;

		private string storeName;

		private string isVideo;

		private string remark;

		private long? size;

		private long? takenAt;

		private int? width;

		private string location;

		private float? longitude;

		private int? height;

		private string md5;

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

		public float? Latitude
		{
			get
			{
				return latitude;
			}
			set	
			{
				latitude = value;
				DictionaryUtil.Add(QueryParameters, "Latitude", value.ToString());
			}
		}

		public string PhotoTitle
		{
			get
			{
				return photoTitle;
			}
			set	
			{
				photoTitle = value;
				DictionaryUtil.Add(QueryParameters, "PhotoTitle", value);
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

		public string IsVideo
		{
			get
			{
				return isVideo;
			}
			set	
			{
				isVideo = value;
				DictionaryUtil.Add(QueryParameters, "IsVideo", value);
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

		public long? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public long? TakenAt
		{
			get
			{
				return takenAt;
			}
			set	
			{
				takenAt = value;
				DictionaryUtil.Add(QueryParameters, "TakenAt", value.ToString());
			}
		}

		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value.ToString());
			}
		}

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(QueryParameters, "Location", value);
			}
		}

		public float? Longitude
		{
			get
			{
				return longitude;
			}
			set	
			{
				longitude = value;
				DictionaryUtil.Add(QueryParameters, "Longitude", value.ToString());
			}
		}

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
			}
		}

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
				DictionaryUtil.Add(QueryParameters, "Md5", value);
			}
		}

        public override RegisterPhotoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RegisterPhotoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}