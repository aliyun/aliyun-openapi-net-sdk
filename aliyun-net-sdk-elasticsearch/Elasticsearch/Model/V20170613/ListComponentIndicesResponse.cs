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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListComponentIndicesResponse : AcsResponse
	{

		private string requestId;

		private List<ListComponentIndices_ResultItem> result;

		private ListComponentIndices_Headers headers;

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

		public List<ListComponentIndices_ResultItem> Result
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

		public ListComponentIndices_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListComponentIndices_ResultItem
		{

			private string name;

			private List<string> composed;

			private ListComponentIndices_Content content;

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

			public List<string> Composed
			{
				get
				{
					return composed;
				}
				set	
				{
					composed = value;
				}
			}

			public ListComponentIndices_Content Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public class ListComponentIndices_Content
			{

				private long? version;

				private string _meta;

				private ListComponentIndices_Template template;

				public long? Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string _Meta
				{
					get
					{
						return _meta;
					}
					set	
					{
						_meta = value;
					}
				}

				public ListComponentIndices_Template Template
				{
					get
					{
						return template;
					}
					set	
					{
						template = value;
					}
				}

				public class ListComponentIndices_Template
				{

					private ListComponentIndices_Settings settings;

					public ListComponentIndices_Settings Settings
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

					public class ListComponentIndices_Settings
					{

						private ListComponentIndices_Index index;

						public ListComponentIndices_Index Index
						{
							get
							{
								return index;
							}
							set	
							{
								index = value;
							}
						}

						public class ListComponentIndices_Index
						{

							private string codec;

							private ListComponentIndices_Lifecycle lifecycle;

							public string Codec
							{
								get
								{
									return codec;
								}
								set	
								{
									codec = value;
								}
							}

							public ListComponentIndices_Lifecycle Lifecycle
							{
								get
								{
									return lifecycle;
								}
								set	
								{
									lifecycle = value;
								}
							}

							public class ListComponentIndices_Lifecycle
							{

								private string name;

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
							}
						}
					}
				}
			}
		}

		public class ListComponentIndices_Headers
		{

			private long? xTotalCount;

			public long? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
