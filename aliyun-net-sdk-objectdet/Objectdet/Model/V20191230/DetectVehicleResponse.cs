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

namespace Aliyun.Acs.objectdet.Model.V20191230
{
	public class DetectVehicleResponse : AcsResponse
	{

		private string requestId;

		private DetectVehicle_Data data;

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

		public DetectVehicle_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DetectVehicle_Data
		{

			private int? width;

			private int? height;

			private List<DetectVehicle_DetectObjectInfo> detectObjectInfoList;

			public int? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public int? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public List<DetectVehicle_DetectObjectInfo> DetectObjectInfoList
			{
				get
				{
					return detectObjectInfoList;
				}
				set	
				{
					detectObjectInfoList = value;
				}
			}

			public class DetectVehicle_DetectObjectInfo
			{

				private float? score;

				private string type;

				private int? id;

				private List<string> boxes;

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
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

				public int? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public List<string> Boxes
				{
					get
					{
						return boxes;
					}
					set	
					{
						boxes = value;
					}
				}
			}
		}
	}
}
