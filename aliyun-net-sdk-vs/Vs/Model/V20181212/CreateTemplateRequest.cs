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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class CreateTemplateRequest : RpcAcsRequest<CreateTemplateResponse>
    {
        public CreateTemplateRequest()
            : base("vs", "2018-12-12", "CreateTemplate", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string hlsTs;

		private string ossEndpoint;

		private string description;

		private string ossFilePrefix;

		private string jpgOverwrite;

		private string startTime;

		private string type;

		private string jpgOnDemand;

		private long? retention;

		private string hlsM3u8;

		private string ossBucket;

		private string transConfigsJSON;

		private string endTime;

		private string trigger;

		private long? ownerId;

		private string jpgSequence;

		private string mp4;

		private string flv;

		private string name;

		private string callback;

		private long? interval;

		private string fileFormat;

		private string region;

		public string HlsTs
		{
			get
			{
				return hlsTs;
			}
			set	
			{
				hlsTs = value;
				DictionaryUtil.Add(QueryParameters, "HlsTs", value);
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public string JpgOverwrite
		{
			get
			{
				return jpgOverwrite;
			}
			set	
			{
				jpgOverwrite = value;
				DictionaryUtil.Add(QueryParameters, "JpgOverwrite", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string JpgOnDemand
		{
			get
			{
				return jpgOnDemand;
			}
			set	
			{
				jpgOnDemand = value;
				DictionaryUtil.Add(QueryParameters, "JpgOnDemand", value);
			}
		}

		public long? Retention
		{
			get
			{
				return retention;
			}
			set	
			{
				retention = value;
				DictionaryUtil.Add(QueryParameters, "Retention", value.ToString());
			}
		}

		public string HlsM3u8
		{
			get
			{
				return hlsM3u8;
			}
			set	
			{
				hlsM3u8 = value;
				DictionaryUtil.Add(QueryParameters, "HlsM3u8", value);
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

		public string TransConfigsJSON
		{
			get
			{
				return transConfigsJSON;
			}
			set	
			{
				transConfigsJSON = value;
				DictionaryUtil.Add(QueryParameters, "TransConfigsJSON", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string Trigger
		{
			get
			{
				return trigger;
			}
			set	
			{
				trigger = value;
				DictionaryUtil.Add(QueryParameters, "Trigger", value);
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

		public string JpgSequence
		{
			get
			{
				return jpgSequence;
			}
			set	
			{
				jpgSequence = value;
				DictionaryUtil.Add(QueryParameters, "JpgSequence", value);
			}
		}

		public string Mp4
		{
			get
			{
				return mp4;
			}
			set	
			{
				mp4 = value;
				DictionaryUtil.Add(QueryParameters, "Mp4", value);
			}
		}

		public string Flv
		{
			get
			{
				return flv;
			}
			set	
			{
				flv = value;
				DictionaryUtil.Add(QueryParameters, "Flv", value);
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

		public string Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value);
			}
		}

		public long? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

		public string FileFormat
		{
			get
			{
				return fileFormat;
			}
			set	
			{
				fileFormat = value;
				DictionaryUtil.Add(QueryParameters, "FileFormat", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

        public override CreateTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
