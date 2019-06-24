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
	public class ListTranscodeTemplateGroupResponse : AcsResponse
	{

		private string requestId;

		private List<ListTranscodeTemplateGroup_TranscodeTemplateGroup> transcodeTemplateGroupList;

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

		public List<ListTranscodeTemplateGroup_TranscodeTemplateGroup> TranscodeTemplateGroupList
		{
			get
			{
				return transcodeTemplateGroupList;
			}
			set	
			{
				transcodeTemplateGroupList = value;
			}
		}

		public class ListTranscodeTemplateGroup_TranscodeTemplateGroup
		{

			private string creationTime;

			private string modifyTime;

			private string name;

			private string isDefault;

			private string locked;

			private string transcodeTemplateGroupId;

			private string transcodeMode;

			private string appId;

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
		}
	}
}
