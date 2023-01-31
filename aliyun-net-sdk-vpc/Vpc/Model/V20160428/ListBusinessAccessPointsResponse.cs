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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListBusinessAccessPointsResponse : AcsResponse
	{

		private string requestId;

		private List<ListBusinessAccessPoints_BusinessAccessPointsItem> businessAccessPoints;

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

		public List<ListBusinessAccessPoints_BusinessAccessPointsItem> BusinessAccessPoints
		{
			get
			{
				return businessAccessPoints;
			}
			set	
			{
				businessAccessPoints = value;
			}
		}

		public class ListBusinessAccessPoints_BusinessAccessPointsItem
		{

			private string accessPointId;

			private string accessPointName;

			private string supportLineOperator;

			private string supportPortTypes;

			private string cloudBoxInstanceIds;

			private double? longitude;

			private double? latitude;

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string AccessPointName
			{
				get
				{
					return accessPointName;
				}
				set	
				{
					accessPointName = value;
				}
			}

			public string SupportLineOperator
			{
				get
				{
					return supportLineOperator;
				}
				set	
				{
					supportLineOperator = value;
				}
			}

			public string SupportPortTypes
			{
				get
				{
					return supportPortTypes;
				}
				set	
				{
					supportPortTypes = value;
				}
			}

			public string CloudBoxInstanceIds
			{
				get
				{
					return cloudBoxInstanceIds;
				}
				set	
				{
					cloudBoxInstanceIds = value;
				}
			}

			public double? Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}

			public double? Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}
		}
	}
}
