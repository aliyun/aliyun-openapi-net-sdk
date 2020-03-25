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
    public class CreateTemplateRequest : RpcAcsRequest<CreateTemplateResponse>
    {
        public CreateTemplateRequest()
            : base("rtc", "2018-01-11", "CreateTemplate", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? serviceMode;

		private List<LiveConfig> liveConfigs = new List<LiveConfig>(){ };

		private int? mediaConfig;

		private int? maxMixStreamCount;

		private List<RecordConfig> recordConfigs = new List<RecordConfig>(){ };

		private long? ownerId;

		private List<LayOut> layOuts = new List<LayOut>(){ };

		private string appId;

		private string callBack;

		private int? mixMode;

		public int? ServiceMode
		{
			get
			{
				return serviceMode;
			}
			set	
			{
				serviceMode = value;
				DictionaryUtil.Add(QueryParameters, "ServiceMode", value.ToString());
			}
		}

		public List<LiveConfig> LiveConfigs
		{
			get
			{
				return liveConfigs;
			}

			set
			{
				liveConfigs = value;
				for (int i = 0; i < liveConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LiveConfig." + (i + 1) + ".DomainName", liveConfigs[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"LiveConfig." + (i + 1) + ".AppName", liveConfigs[i].AppName);
				}
			}
		}

		public int? MediaConfig
		{
			get
			{
				return mediaConfig;
			}
			set	
			{
				mediaConfig = value;
				DictionaryUtil.Add(QueryParameters, "MediaConfig", value.ToString());
			}
		}

		public int? MaxMixStreamCount
		{
			get
			{
				return maxMixStreamCount;
			}
			set	
			{
				maxMixStreamCount = value;
				DictionaryUtil.Add(QueryParameters, "MaxMixStreamCount", value.ToString());
			}
		}

		public List<RecordConfig> RecordConfigs
		{
			get
			{
				return recordConfigs;
			}

			set
			{
				recordConfigs = value;
				for (int i = 0; i < recordConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RecordConfig." + (i + 1) + ".StorageType", recordConfigs[i].StorageType);
					DictionaryUtil.Add(QueryParameters,"RecordConfig." + (i + 1) + ".FileFormat", recordConfigs[i].FileFormat);
					DictionaryUtil.Add(QueryParameters,"RecordConfig." + (i + 1) + ".OssEndPoint", recordConfigs[i].OssEndPoint);
					DictionaryUtil.Add(QueryParameters,"RecordConfig." + (i + 1) + ".OssBucket", recordConfigs[i].OssBucket);
					DictionaryUtil.Add(QueryParameters,"RecordConfig." + (i + 1) + ".VodTransCodeGroupId", recordConfigs[i].VodTransCodeGroupId);
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

		public List<LayOut> LayOuts
		{
			get
			{
				return layOuts;
			}

			set
			{
				layOuts = value;
				for (int i = 0; i < layOuts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LayOut." + (i + 1) + ".Color", layOuts[i].Color);
					DictionaryUtil.Add(QueryParameters,"LayOut." + (i + 1) + ".CutMode", layOuts[i].CutMode);
					DictionaryUtil.Add(QueryParameters,"LayOut." + (i + 1) + ".LayOutId", layOuts[i].LayOutId);
				}
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

		public string CallBack
		{
			get
			{
				return callBack;
			}
			set	
			{
				callBack = value;
				DictionaryUtil.Add(QueryParameters, "CallBack", value);
			}
		}

		public int? MixMode
		{
			get
			{
				return mixMode;
			}
			set	
			{
				mixMode = value;
				DictionaryUtil.Add(QueryParameters, "MixMode", value.ToString());
			}
		}

		public class LiveConfig
		{

			private string domainName;

			private string appName;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}
		}

		public class RecordConfig
		{

			private string storageType;

			private int? fileFormat;

			private string ossEndPoint;

			private string ossBucket;

			private int? vodTransCodeGroupId;

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public int? FileFormat
			{
				get
				{
					return fileFormat;
				}
				set	
				{
					fileFormat = value;
				}
			}

			public string OssEndPoint
			{
				get
				{
					return ossEndPoint;
				}
				set	
				{
					ossEndPoint = value;
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
				}
			}

			public int? VodTransCodeGroupId
			{
				get
				{
					return vodTransCodeGroupId;
				}
				set	
				{
					vodTransCodeGroupId = value;
				}
			}
		}

		public class LayOut
		{

			private string color;

			private int? cutMode;

			private int? layOutId;

			public string Color
			{
				get
				{
					return color;
				}
				set	
				{
					color = value;
				}
			}

			public int? CutMode
			{
				get
				{
					return cutMode;
				}
				set	
				{
					cutMode = value;
				}
			}

			public int? LayOutId
			{
				get
				{
					return layOutId;
				}
				set	
				{
					layOutId = value;
				}
			}
		}

        public override CreateTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
