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

namespace Aliyun.Acs.DBFS.Model.V20200418
{
	public class ListDbfsAttachableEcsInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListDbfsAttachableEcsInstances_LabelInfo> ecsLabelInfo;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "EcsLabelInfo")]
		public List<ListDbfsAttachableEcsInstances_LabelInfo> EcsLabelInfo
		{
			get
			{
				return ecsLabelInfo;
			}
			set	
			{
				ecsLabelInfo = value;
			}
		}

		public class ListDbfsAttachableEcsInstances_LabelInfo
		{

			private string _value;

			private string label;

			private string instanceTypeFamily;

			private string oSName;

			private string status;

			private string zoneId;

			private string imageId;

			[JsonProperty(PropertyName = "_Value")]
			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			[JsonProperty(PropertyName = "Label")]
			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceTypeFamily")]
			public string InstanceTypeFamily
			{
				get
				{
					return instanceTypeFamily;
				}
				set	
				{
					instanceTypeFamily = value;
				}
			}

			[JsonProperty(PropertyName = "OSName")]
			public string OSName
			{
				get
				{
					return oSName;
				}
				set	
				{
					oSName = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "ZoneId")]
			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			[JsonProperty(PropertyName = "ImageId")]
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
		}
	}
}
