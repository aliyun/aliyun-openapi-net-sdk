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
using Aliyun.Acs.videoenhan.Transform;
using Aliyun.Acs.videoenhan.Transform.V20200320;

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
    public class GenerateVideoRequest : RpcAcsRequest<GenerateVideoResponse>
    {
        public GenerateVideoRequest()
            : base("videoenhan", "2020-03-20", "GenerateVideo", "videoenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string transitionStyle;

		private string scene;

		private float? duration;

		private bool? puzzleEffect;

		private int? height;

		private bool? durationAdaption;

		private List<FileList> fileLists = new List<FileList>(){ };

		private bool? mute;

		private bool? smartEffect;

		private int? width;

		private string style;

		public string TransitionStyle
		{
			get
			{
				return transitionStyle;
			}
			set	
			{
				transitionStyle = value;
				DictionaryUtil.Add(BodyParameters, "TransitionStyle", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(BodyParameters, "Scene", value);
			}
		}

		public float? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(BodyParameters, "Duration", value.ToString());
			}
		}

		public bool? PuzzleEffect
		{
			get
			{
				return puzzleEffect;
			}
			set	
			{
				puzzleEffect = value;
				DictionaryUtil.Add(BodyParameters, "PuzzleEffect", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "Height", value.ToString());
			}
		}

		public bool? DurationAdaption
		{
			get
			{
				return durationAdaption;
			}
			set	
			{
				durationAdaption = value;
				DictionaryUtil.Add(BodyParameters, "DurationAdaption", value.ToString());
			}
		}

		public List<FileList> FileLists
		{
			get
			{
				return fileLists;
			}

			set
			{
				fileLists = value;
				for (int i = 0; i < fileLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"FileList." + (i + 1) + ".FileName", fileLists[i].FileName);
					DictionaryUtil.Add(BodyParameters,"FileList." + (i + 1) + ".FileUrl", fileLists[i].FileUrl);
					DictionaryUtil.Add(BodyParameters,"FileList." + (i + 1) + ".Type", fileLists[i].Type);
				}
			}
		}

		public bool? Mute
		{
			get
			{
				return mute;
			}
			set	
			{
				mute = value;
				DictionaryUtil.Add(BodyParameters, "Mute", value.ToString());
			}
		}

		public bool? SmartEffect
		{
			get
			{
				return smartEffect;
			}
			set	
			{
				smartEffect = value;
				DictionaryUtil.Add(BodyParameters, "SmartEffect", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "Width", value.ToString());
			}
		}

		public string Style
		{
			get
			{
				return style;
			}
			set	
			{
				style = value;
				DictionaryUtil.Add(BodyParameters, "Style", value);
			}
		}

		public class FileList
		{

			private string fileName;

			private string fileUrl;

			private string type;

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public string FileUrl
			{
				get
				{
					return fileUrl;
				}
				set	
				{
					fileUrl = value;
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
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GenerateVideoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GenerateVideoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
