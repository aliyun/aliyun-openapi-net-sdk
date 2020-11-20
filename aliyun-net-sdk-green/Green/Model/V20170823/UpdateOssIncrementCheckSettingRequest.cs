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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateOssIncrementCheckSettingRequest : RpcAcsRequest<UpdateOssIncrementCheckSettingResponse>
    {
        public UpdateOssIncrementCheckSettingRequest()
            : base("Green", "2017-08-23", "UpdateOssIncrementCheckSetting", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string videoSceneList;

		private string imageSceneList;

		private int? videoFrameInterval;

		private string sourceIp;

		private string callbackId;

		private string imageScanLimit;

		private string videoAutoFreezeSceneList;

		private string lang;

		private string imageAutoFreeze;

		private int? videoMaxSize;

		private string autoFreezeType;

		private string bucketConfigList;

		private int? videoMaxFrames;

		public string VideoSceneList
		{
			get
			{
				return videoSceneList;
			}
			set	
			{
				videoSceneList = value;
				DictionaryUtil.Add(QueryParameters, "VideoSceneList", value);
			}
		}

		public string ImageSceneList
		{
			get
			{
				return imageSceneList;
			}
			set	
			{
				imageSceneList = value;
				DictionaryUtil.Add(QueryParameters, "ImageSceneList", value);
			}
		}

		public int? VideoFrameInterval
		{
			get
			{
				return videoFrameInterval;
			}
			set	
			{
				videoFrameInterval = value;
				DictionaryUtil.Add(QueryParameters, "VideoFrameInterval", value.ToString());
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string CallbackId
		{
			get
			{
				return callbackId;
			}
			set	
			{
				callbackId = value;
				DictionaryUtil.Add(QueryParameters, "CallbackId", value);
			}
		}

		public string ImageScanLimit
		{
			get
			{
				return imageScanLimit;
			}
			set	
			{
				imageScanLimit = value;
				DictionaryUtil.Add(QueryParameters, "ImageScanLimit", value);
			}
		}

		public string VideoAutoFreezeSceneList
		{
			get
			{
				return videoAutoFreezeSceneList;
			}
			set	
			{
				videoAutoFreezeSceneList = value;
				DictionaryUtil.Add(QueryParameters, "VideoAutoFreezeSceneList", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string ImageAutoFreeze
		{
			get
			{
				return imageAutoFreeze;
			}
			set	
			{
				imageAutoFreeze = value;
				DictionaryUtil.Add(QueryParameters, "ImageAutoFreeze", value);
			}
		}

		public int? VideoMaxSize
		{
			get
			{
				return videoMaxSize;
			}
			set	
			{
				videoMaxSize = value;
				DictionaryUtil.Add(QueryParameters, "VideoMaxSize", value.ToString());
			}
		}

		public string AutoFreezeType
		{
			get
			{
				return autoFreezeType;
			}
			set	
			{
				autoFreezeType = value;
				DictionaryUtil.Add(QueryParameters, "AutoFreezeType", value);
			}
		}

		public string BucketConfigList
		{
			get
			{
				return bucketConfigList;
			}
			set	
			{
				bucketConfigList = value;
				DictionaryUtil.Add(QueryParameters, "BucketConfigList", value);
			}
		}

		public int? VideoMaxFrames
		{
			get
			{
				return videoMaxFrames;
			}
			set	
			{
				videoMaxFrames = value;
				DictionaryUtil.Add(QueryParameters, "VideoMaxFrames", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateOssIncrementCheckSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateOssIncrementCheckSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
