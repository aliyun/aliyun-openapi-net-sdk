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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetTranscodeTemplateGroupResponse : AcsResponse
	{

		private string requestId;

		private GetTranscodeTemplateGroup_TranscodeTemplateGroup transcodeTemplateGroup;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetTranscodeTemplateGroup_TranscodeTemplateGroup TranscodeTemplateGroup
		{
			get
			{
				return transcodeTemplateGroup;
			}
			set	
			{
				transcodeTemplateGroup = value;
			}
		}

		public class GetTranscodeTemplateGroup_TranscodeTemplateGroup
		{

			private string creationTime;

			private string modifyTime;

			private string name;

			private string isDefault;

			private string locked;

			private string transcodeMode;

			private string appId;

			private string transcodeTemplateGroupId;

			private List<GetTranscodeTemplateGroup_TranscodeTemplate> transcodeTemplateList;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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
				}
			}

			public string IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string Locked
			{
				get
				{
					return locked;
				}
				set	
				{
					locked = value;
				}
			}

			public string TranscodeMode
			{
				get
				{
					return transcodeMode;
				}
				set	
				{
					transcodeMode = value;
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
				}
			}

			public string TranscodeTemplateGroupId
			{
				get
				{
					return transcodeTemplateGroupId;
				}
				set	
				{
					transcodeTemplateGroupId = value;
				}
			}

			public List<GetTranscodeTemplateGroup_TranscodeTemplate> TranscodeTemplateList
			{
				get
				{
					return transcodeTemplateList;
				}
				set	
				{
					transcodeTemplateList = value;
				}
			}

			public class GetTranscodeTemplateGroup_TranscodeTemplate
			{

				private string transcodeTemplateId;

				private string video;

				private string audio;

				private string container;

				private string muxConfig;

				private string transConfig;

				private string definition;

				private string encryptSetting;

				private string packageSetting;

				private string subtitleList;

				private string openingList;

				private string tailSlateList;

				private string templateName;

				private string transcodeFileRegular;

				private string clip;

				private string rotate;

				private string type;

				private string userData;

				private List<string> watermarkIds;

				public string TranscodeTemplateId
				{
					get
					{
						return transcodeTemplateId;
					}
					set	
					{
						transcodeTemplateId = value;
					}
				}

				public string Video
				{
					get
					{
						return video;
					}
					set	
					{
						video = value;
					}
				}

				public string Audio
				{
					get
					{
						return audio;
					}
					set	
					{
						audio = value;
					}
				}

				public string Container
				{
					get
					{
						return container;
					}
					set	
					{
						container = value;
					}
				}

				public string MuxConfig
				{
					get
					{
						return muxConfig;
					}
					set	
					{
						muxConfig = value;
					}
				}

				public string TransConfig
				{
					get
					{
						return transConfig;
					}
					set	
					{
						transConfig = value;
					}
				}

				public string Definition
				{
					get
					{
						return definition;
					}
					set	
					{
						definition = value;
					}
				}

				public string EncryptSetting
				{
					get
					{
						return encryptSetting;
					}
					set	
					{
						encryptSetting = value;
					}
				}

				public string PackageSetting
				{
					get
					{
						return packageSetting;
					}
					set	
					{
						packageSetting = value;
					}
				}

				public string SubtitleList
				{
					get
					{
						return subtitleList;
					}
					set	
					{
						subtitleList = value;
					}
				}

				public string OpeningList
				{
					get
					{
						return openingList;
					}
					set	
					{
						openingList = value;
					}
				}

				public string TailSlateList
				{
					get
					{
						return tailSlateList;
					}
					set	
					{
						tailSlateList = value;
					}
				}

				public string TemplateName
				{
					get
					{
						return templateName;
					}
					set	
					{
						templateName = value;
					}
				}

				public string TranscodeFileRegular
				{
					get
					{
						return transcodeFileRegular;
					}
					set	
					{
						transcodeFileRegular = value;
					}
				}

				public string Clip
				{
					get
					{
						return clip;
					}
					set	
					{
						clip = value;
					}
				}

				public string Rotate
				{
					get
					{
						return rotate;
					}
					set	
					{
						rotate = value;
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

				public string UserData
				{
					get
					{
						return userData;
					}
					set	
					{
						userData = value;
					}
				}

				public List<string> WatermarkIds
				{
					get
					{
						return watermarkIds;
					}
					set	
					{
						watermarkIds = value;
					}
				}
			}
		}
	}
}
