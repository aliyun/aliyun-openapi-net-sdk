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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class GetFabricTopologyResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetFabricTopology_Content content;

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

		public GetFabricTopology_Content Content
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

		public class GetFabricTopology_Content
		{

			private string regionId;

			private string vpdId;

			private string vpcId;

			private string clusterId;

			private List<GetFabricTopology_Layer> topoInfo;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string VpdId
			{
				get
				{
					return vpdId;
				}
				set	
				{
					vpdId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public List<GetFabricTopology_Layer> TopoInfo
			{
				get
				{
					return topoInfo;
				}
				set	
				{
					topoInfo = value;
				}
			}

			public class GetFabricTopology_Layer
			{

				private string layerType;

				private string layerName;

				private List<string> nextLayer;

				public string LayerType
				{
					get
					{
						return layerType;
					}
					set	
					{
						layerType = value;
					}
				}

				public string LayerName
				{
					get
					{
						return layerName;
					}
					set	
					{
						layerName = value;
					}
				}

				public List<string> NextLayer
				{
					get
					{
						return nextLayer;
					}
					set	
					{
						nextLayer = value;
					}
				}
			}
		}
	}
}
