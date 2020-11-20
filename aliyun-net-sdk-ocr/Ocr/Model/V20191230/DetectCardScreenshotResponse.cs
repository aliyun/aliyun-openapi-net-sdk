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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class DetectCardScreenshotResponse : AcsResponse
	{

		private string requestId;

		private DetectCardScreenshot_Data data;

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

		public DetectCardScreenshot_Data Data
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

		public class DetectCardScreenshot_Data
		{

			private bool? isCard;

			private bool? isBlur;

			private DetectCardScreenshot_SpoofResult spoofResult;

			public bool? IsCard
			{
				get
				{
					return isCard;
				}
				set	
				{
					isCard = value;
				}
			}

			public bool? IsBlur
			{
				get
				{
					return isBlur;
				}
				set	
				{
					isBlur = value;
				}
			}

			public DetectCardScreenshot_SpoofResult SpoofResult
			{
				get
				{
					return spoofResult;
				}
				set	
				{
					spoofResult = value;
				}
			}

			public class DetectCardScreenshot_SpoofResult
			{

				private bool? isSpoof;

				private DetectCardScreenshot_ResultMap resultMap;

				public bool? IsSpoof
				{
					get
					{
						return isSpoof;
					}
					set	
					{
						isSpoof = value;
					}
				}

				public DetectCardScreenshot_ResultMap ResultMap
				{
					get
					{
						return resultMap;
					}
					set	
					{
						resultMap = value;
					}
				}

				public class DetectCardScreenshot_ResultMap
				{

					private float? screenScore;

					private float? screenThreshold;

					public float? ScreenScore
					{
						get
						{
							return screenScore;
						}
						set	
						{
							screenScore = value;
						}
					}

					public float? ScreenThreshold
					{
						get
						{
							return screenThreshold;
						}
						set	
						{
							screenThreshold = value;
						}
					}
				}
			}
		}
	}
}
