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
using Aliyun.Acs.vod;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class SubmitSnapshotJobRequest : RpcAcsRequest<SubmitSnapshotJobResponse>
    {
        public SubmitSnapshotJobRequest()
            : base("vod", "2017-03-21", "SubmitSnapshotJob")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userData;

		private long? specifiedOffsetTime;

		private string spriteSnapshotConfig;

		private string snapshotTemplateId;

		private string height;

		private long? count;

		private string videoId;

		private string width;

		private long? interval;

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public long? SpecifiedOffsetTime
		{
			get
			{
				return specifiedOffsetTime;
			}
			set	
			{
				specifiedOffsetTime = value;
				DictionaryUtil.Add(QueryParameters, "SpecifiedOffsetTime", value.ToString());
			}
		}

		public string SpriteSnapshotConfig
		{
			get
			{
				return spriteSnapshotConfig;
			}
			set	
			{
				spriteSnapshotConfig = value;
				DictionaryUtil.Add(QueryParameters, "SpriteSnapshotConfig", value);
			}
		}

		public string SnapshotTemplateId
		{
			get
			{
				return snapshotTemplateId;
			}
			set	
			{
				snapshotTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotTemplateId", value);
			}
		}

		public string Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value);
			}
		}

		public long? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
				DictionaryUtil.Add(QueryParameters, "Count", value.ToString());
			}
		}

		public string VideoId
		{
			get
			{
				return videoId;
			}
			set	
			{
				videoId = value;
				DictionaryUtil.Add(QueryParameters, "VideoId", value);
			}
		}

		public string Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value);
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

        public override SubmitSnapshotJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitSnapshotJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
