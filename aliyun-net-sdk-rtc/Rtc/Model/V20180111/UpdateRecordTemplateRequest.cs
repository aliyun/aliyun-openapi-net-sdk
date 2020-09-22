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
    public class UpdateRecordTemplateRequest : RpcAcsRequest<UpdateRecordTemplateResponse>
    {
        public UpdateRecordTemplateRequest()
            : base("rtc", "2018-01-11", "UpdateRecordTemplate", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> formatss = new List<string>(){ };

		private string ossFilePrefix;

		private int? backgroundColor;

		private string taskProfile;

		private List<long?> layoutIdss = new List<long?>(){ };

		private string ossBucket;

		private string mnsQueue;

		private int? fileSplitInterval;

		private long? ownerId;

		private string templateId;

		private string appId;

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

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateRecordTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateRecordTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
