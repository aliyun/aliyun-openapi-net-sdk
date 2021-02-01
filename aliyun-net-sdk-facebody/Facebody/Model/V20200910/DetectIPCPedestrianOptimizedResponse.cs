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

namespace Aliyun.Acs.facebody.Model.V20200910
{
	public class DetectIPCPedestrianOptimizedResponse : AcsResponse
	{

		private string requestId;

		private DetectIPCPedestrianOptimized_Data data;

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

		public DetectIPCPedestrianOptimized_Data Data
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

		public class DetectIPCPedestrianOptimized_Data
		{

			private List<DetectIPCPedestrianOptimized_ImageInfoListItem> imageInfoList;

			public List<DetectIPCPedestrianOptimized_ImageInfoListItem> ImageInfoList
			{
				get
				{
					return imageInfoList;
				}
				set	
				{
					imageInfoList = value;
				}
			}

			public class DetectIPCPedestrianOptimized_ImageInfoListItem
			{

				private List<DetectIPCPedestrianOptimized_Element> elements;

				public List<DetectIPCPedestrianOptimized_Element> Elements
				{
					get
					{
						return elements;
					}
					set	
					{
						elements = value;
					}
				}

				public class DetectIPCPedestrianOptimized_Element
				{

					private float? score;

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
}
