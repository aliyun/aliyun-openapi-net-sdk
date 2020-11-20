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
    public class ModifyMPULayoutRequest : RpcAcsRequest<ModifyMPULayoutResponse>
    {
        public ModifyMPULayoutRequest()
            : base("rtc", "2018-01-11", "ModifyMPULayout", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? layoutId;

		private List<Panes> paness = new List<Panes>(){ };

		private long? ownerId;

		private string appId;

		private string name;

		private int? audioMixCount;

		public long? LayoutId
		{
			get
			{
				return layoutId;
			}
			set	
			{
				layoutId = value;
				DictionaryUtil.Add(QueryParameters, "LayoutId", value.ToString());
			}
		}

		public List<Panes> Paness
		{
			get
			{
				return paness;
			}

			set
			{
				paness = value;
				for (int i = 0; i < paness.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".PaneId", paness[i].PaneId);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".MajorPane", paness[i].MajorPane);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".X", paness[i].X);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".Y", paness[i].Y);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".Width", paness[i].Width);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".Height", paness[i].Height);
					DictionaryUtil.Add(QueryParameters,"Panes." + (i + 1) + ".ZOrder", paness[i].ZOrder);
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

		public int? AudioMixCount
		{
			get
			{
				return audioMixCount;
			}
			set	
			{
				audioMixCount = value;
				DictionaryUtil.Add(QueryParameters, "AudioMixCount", value.ToString());
			}
		}

		public class Panes
		{

			private int? paneId;

			private int? majorPane;

			private float? x;

			private float? y;

			private float? width;

			private float? height;

			private int? zOrder;

			public int? PaneId
			{
				get
				{
					return paneId;
				}
				set	
				{
					paneId = value;
				}
			}

			public int? MajorPane
			{
				get
				{
					return majorPane;
				}
				set	
				{
					majorPane = value;
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

        public override ModifyMPULayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyMPULayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
