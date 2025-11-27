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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryWorksBloodRelationshipResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<QueryWorksBloodRelationship_Item> result;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<QueryWorksBloodRelationship_Item> Result
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

		public class QueryWorksBloodRelationship_Item
		{

			private string componentId;

			private string componentName;

			private int? componentType;

			private string componentTypeName;

			private string componentTypeCnName;

			private string datasetId;

			private List<QueryWorksBloodRelationship_QueryParam> queryParams;

			public string ComponentId
			{
				get
				{
					return componentId;
				}
				set	
				{
					componentId = value;
				}
			}

			public string ComponentName
			{
				get
				{
					return componentName;
				}
				set	
				{
					componentName = value;
				}
			}

			public int? ComponentType
			{
				get
				{
					return componentType;
				}
				set	
				{
					componentType = value;
				}
			}

			public string ComponentTypeName
			{
				get
				{
					return componentTypeName;
				}
				set	
				{
					componentTypeName = value;
				}
			}

			public string ComponentTypeCnName
			{
				get
				{
					return componentTypeCnName;
				}
				set	
				{
					componentTypeCnName = value;
				}
			}

			public string DatasetId
			{
				get
				{
					return datasetId;
				}
				set	
				{
					datasetId = value;
				}
			}

			public List<QueryWorksBloodRelationship_QueryParam> QueryParams
			{
				get
				{
					return queryParams;
				}
				set	
				{
					queryParams = value;
				}
			}

			public class QueryWorksBloodRelationship_QueryParam
			{

				private string areaId;

				private string areaName;

				private string caption;

				private string dataType;

				private bool? isMeasure;

				private string pathId;

				private string uid;

				private string expression;

				public string AreaId
				{
					get
					{
						return areaId;
					}
					set	
					{
						areaId = value;
					}
				}

				public string AreaName
				{
					get
					{
						return areaName;
					}
					set	
					{
						areaName = value;
					}
				}

				public string Caption
				{
					get
					{
						return caption;
					}
					set	
					{
						caption = value;
					}
				}

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public bool? IsMeasure
				{
					get
					{
						return isMeasure;
					}
					set	
					{
						isMeasure = value;
					}
				}

				public string PathId
				{
					get
					{
						return pathId;
					}
					set	
					{
						pathId = value;
					}
				}

				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}

				public string Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}
			}
		}
	}
}
