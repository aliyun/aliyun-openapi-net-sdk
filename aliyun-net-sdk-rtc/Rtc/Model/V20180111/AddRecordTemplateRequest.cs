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
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class AddRecordTemplateRequest : RpcAcsRequest<AddRecordTemplateResponse>
    {
        public AddRecordTemplateRequest()
            : base("rtc", "2018-01-11", "AddRecordTemplate", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> formatss = new List<string>(){ };

		private string ossFilePrefix;

		private int? backgroundColor;

		private string taskProfile;

		private List<long?> layoutIdss = new List<long?>(){ };

		private string ossBucket;

		private int? delayStopTime;

		private int? fileSplitInterval;

		private string mnsQueue;

		private string httpCallbackUrl;

		private List<Watermarks> watermarkss = new List<Watermarks>(){ };

		private long? ownerId;

		private string appId;

		private List<Backgrounds> backgroundss = new List<Backgrounds>(){ };

		private string name;

		private int? mediaEncode;

		public List<string> Formatss
		{
			get
			{
				return formatss;
			}

			set
			{
				formatss = value;
				for (int i = 0; i < formatss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Formats." + (i + 1) , formatss[i]);
				}
			}
		}

		public string OssFilePrefix
		{
			get
			{
				return ossFilePrefix;
			}
			set	
			{
				ossFilePrefix = value;
				DictionaryUtil.Add(QueryParameters, "OssFilePrefix", value);
			}
		}

		public int? BackgroundColor
		{
			get
			{
				return backgroundColor;
			}
			set	
			{
				backgroundColor = value;
				DictionaryUtil.Add(QueryParameters, "BackgroundColor", value.ToString());
			}
		}

		public string TaskProfile
		{
			get
			{
				return taskProfile;
			}
			set	
			{
				taskProfile = value;
				DictionaryUtil.Add(QueryParameters, "TaskProfile", value);
			}
		}

		public List<long?> LayoutIdss
		{
			get
			{
				return layoutIdss;
			}

			set
			{
				layoutIdss = value;
				for (int i = 0; i < layoutIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LayoutIds." + (i + 1) , layoutIdss[i]);
				}
			}
		}

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
				DictionaryUtil.Add(QueryParameters, "OssBucket", value);
			}
		}

		public int? DelayStopTime
		{
			get
			{
				return delayStopTime;
			}
			set	
			{
				delayStopTime = value;
				DictionaryUtil.Add(QueryParameters, "DelayStopTime", value.ToString());
			}
		}

		public int? FileSplitInterval
		{
			get
			{
				return fileSplitInterval;
			}
			set	
			{
				fileSplitInterval = value;
				DictionaryUtil.Add(QueryParameters, "FileSplitInterval", value.ToString());
			}
		}

		public string MnsQueue
		{
			get
			{
				return mnsQueue;
			}
			set	
			{
				mnsQueue = value;
				DictionaryUtil.Add(QueryParameters, "MnsQueue", value);
			}
		}

		public string HttpCallbackUrl
		{
			get
			{
				return httpCallbackUrl;
			}
			set	
			{
				httpCallbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "HttpCallbackUrl", value);
			}
		}

		public List<Watermarks> Watermarkss
		{
			get
			{
				return watermarkss;
			}

			set
			{
				watermarkss = value;
				for (int i = 0; i < watermarkss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Url", watermarkss[i].Url);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Alpha", watermarkss[i].Alpha);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Display", watermarkss[i].Display);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".X", watermarkss[i].X);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Y", watermarkss[i].Y);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Width", watermarkss[i].Width);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".Height", watermarkss[i].Height);
					DictionaryUtil.Add(QueryParameters,"Watermarks." + (i + 1) + ".ZOrder", watermarkss[i].ZOrder);
				}
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public List<Backgrounds> Backgroundss
		{
			get
			{
				return backgroundss;
			}

			set
			{
				backgroundss = value;
				for (int i = 0; i < backgroundss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Url", backgroundss[i].Url);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Display", backgroundss[i].Display);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".X", backgroundss[i].X);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Y", backgroundss[i].Y);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Width", backgroundss[i].Width);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".Height", backgroundss[i].Height);
					DictionaryUtil.Add(QueryParameters,"Backgrounds." + (i + 1) + ".ZOrder", backgroundss[i].ZOrder);
				}
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? MediaEncode
		{
			get
			{
				return mediaEncode;
			}
			set	
			{
				mediaEncode = value;
				DictionaryUtil.Add(QueryParameters, "MediaEncode", value.ToString());
			}
		}

		public class Watermarks
		{

			private string url;

			private float? alpha;

			private int? display;

			private float? x;

			private float? y;

			private float? width;

			private float? height;

			private int? zOrder;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public float? Alpha
			{
				get
				{
					return alpha;
				}
				set	
				{
					alpha = value;
				}
			}

			public int? Display
			{
				get
				{
					return display;
				}
				set	
				{
					display = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public float? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public float? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public int? ZOrder
			{
				get
				{
					return zOrder;
				}
				set	
				{
					zOrder = value;
				}
			}
		}

		public class Backgrounds
		{

			private string url;

			private int? display;

			private float? x;

			private float? y;

			private float? width;

			private float? height;

			private int? zOrder;

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public int? Display
			{
				get
				{
					return display;
				}
				set	
				{
					display = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public float? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public float? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public int? ZOrder
			{
				get
				{
					return zOrder;
				}
				set	
				{
					zOrder = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddRecordTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddRecordTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
