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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListBuildPackResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListBuildPack_BuildPack> buildPackList;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public List<ListBuildPack_BuildPack> BuildPackList
		{
			get
			{
				return buildPackList;
			}
			set	
			{
				buildPackList = value;
			}
		}

		public class ListBuildPack_BuildPack
		{

			private long? configId;

			private string packVersion;

			private string tomcatDesc;

			private string tomcatVersion;

			private string tomcatDownloadUrl;

			private string pandoraVersion;

			private string pandoraDownloadUrl;

			private string pandoraDesc;

			private string pluginInfo;

			private string tomcatPath;

			private string imageId;

			private string tengineImageId;

			private bool? multipleTenant;

			private bool? withTengine;

			private string tengineDownloadUrl;

			private string scriptName;

			private string scriptVersion;

			private string feature;

			private string supportFeatures;

			private bool? disabled;

			public long? ConfigId
			{
				get
				{
					return configId;
				}
				set	
				{
					configId = value;
				}
			}

			public string PackVersion
			{
				get
				{
					return packVersion;
				}
				set	
				{
					packVersion = value;
				}
			}

			public string TomcatDesc
			{
				get
				{
					return tomcatDesc;
				}
				set	
				{
					tomcatDesc = value;
				}
			}

			public string TomcatVersion
			{
				get
				{
					return tomcatVersion;
				}
				set	
				{
					tomcatVersion = value;
				}
			}

			public string TomcatDownloadUrl
			{
				get
				{
					return tomcatDownloadUrl;
				}
				set	
				{
					tomcatDownloadUrl = value;
				}
			}

			public string PandoraVersion
			{
				get
				{
					return pandoraVersion;
				}
				set	
				{
					pandoraVersion = value;
				}
			}

			public string PandoraDownloadUrl
			{
				get
				{
					return pandoraDownloadUrl;
				}
				set	
				{
					pandoraDownloadUrl = value;
				}
			}

			public string PandoraDesc
			{
				get
				{
					return pandoraDesc;
				}
				set	
				{
					pandoraDesc = value;
				}
			}

			public string PluginInfo
			{
				get
				{
					return pluginInfo;
				}
				set	
				{
					pluginInfo = value;
				}
			}

			public string TomcatPath
			{
				get
				{
					return tomcatPath;
				}
				set	
				{
					tomcatPath = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string TengineImageId
			{
				get
				{
					return tengineImageId;
				}
				set	
				{
					tengineImageId = value;
				}
			}

			public bool? MultipleTenant
			{
				get
				{
					return multipleTenant;
				}
				set	
				{
					multipleTenant = value;
				}
			}

			public bool? WithTengine
			{
				get
				{
					return withTengine;
				}
				set	
				{
					withTengine = value;
				}
			}

			public string TengineDownloadUrl
			{
				get
				{
					return tengineDownloadUrl;
				}
				set	
				{
					tengineDownloadUrl = value;
				}
			}

			public string ScriptName
			{
				get
				{
					return scriptName;
				}
				set	
				{
					scriptName = value;
				}
			}

			public string ScriptVersion
			{
				get
				{
					return scriptVersion;
				}
				set	
				{
					scriptVersion = value;
				}
			}

			public string Feature
			{
				get
				{
					return feature;
				}
				set	
				{
					feature = value;
				}
			}

			public string SupportFeatures
			{
				get
				{
					return supportFeatures;
				}
				set	
				{
					supportFeatures = value;
				}
			}

			public bool? Disabled
			{
				get
				{
					return disabled;
				}
				set	
				{
					disabled = value;
				}
			}
		}
	}
}
