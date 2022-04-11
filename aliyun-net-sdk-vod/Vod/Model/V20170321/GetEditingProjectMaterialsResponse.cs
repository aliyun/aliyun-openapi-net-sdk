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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetEditingProjectMaterialsResponse : AcsResponse
	{

		private string requestId;

		private List<GetEditingProjectMaterials_Material> materialList;

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

		public List<GetEditingProjectMaterials_Material> MaterialList
		{
			get
			{
				return materialList;
			}
			set	
			{
				materialList = value;
			}
		}

		public class GetEditingProjectMaterials_Material
		{

			private string status;

			private string creationTime;

			private int? cateId;

			private string materialType;

			private string tags;

			private string spriteConfig;

			private string source;

			private string cateName;

			private string modifiedTime;

			private string description;

			private string materialId;

			private long? size;

			private string coverURL;

			private float? duration;

			private string title;

			private List<string> sprites;

			private List<string> snapshots;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

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

			public int? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public string MaterialType
			{
				get
				{
					return materialType;
				}
				set	
				{
					materialType = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public string SpriteConfig
			{
				get
				{
					return spriteConfig;
				}
				set	
				{
					spriteConfig = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string CateName
			{
				get
				{
					return cateName;
				}
				set	
				{
					cateName = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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
				}
			}

			public string MaterialId
			{
				get
				{
					return materialId;
				}
				set	
				{
					materialId = value;
				}
			}

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string CoverURL
			{
				get
				{
					return coverURL;
				}
				set	
				{
					coverURL = value;
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
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public List<string> Sprites
			{
				get
				{
					return sprites;
				}
				set	
				{
					sprites = value;
				}
			}

			public List<string> Snapshots
			{
				get
				{
					return snapshots;
				}
				set	
				{
					snapshots = value;
				}
			}
		}
	}
}
