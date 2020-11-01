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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class GetClusterDataInformationResponse : AcsResponse
	{

		private string requestId;

		private GetClusterDataInformation_Result result;

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

		public GetClusterDataInformation_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetClusterDataInformation_Result
		{

			private bool? connectable;

			private GetClusterDataInformation_MetaInfo metaInfo;

			public bool? Connectable
			{
				get
				{
					return connectable;
				}
				set	
				{
					connectable = value;
				}
			}

			public GetClusterDataInformation_MetaInfo MetaInfo
			{
				get
				{
					return metaInfo;
				}
				set	
				{
					metaInfo = value;
				}
			}

			public class GetClusterDataInformation_MetaInfo
			{

				private string settings;

				private string mapping;

				private List<string> indices;

				private List<string> fields;

				private List<string> typeName;

				public string Settings
				{
					get
					{
						return settings;
					}
					set	
					{
						settings = value;
					}
				}

				public string Mapping
				{
					get
					{
						return mapping;
					}
					set	
					{
						mapping = value;
					}
				}

				public List<string> Indices
				{
					get
					{
						return indices;
					}
					set	
					{
						indices = value;
					}
				}

				public List<string> Fields
				{
					get
					{
						return fields;
					}
					set	
					{
						fields = value;
					}
				}

				public List<string> TypeName
				{
					get
					{
						return typeName;
					}
					set	
					{
						typeName = value;
					}
				}
			}
		}
	}
}
