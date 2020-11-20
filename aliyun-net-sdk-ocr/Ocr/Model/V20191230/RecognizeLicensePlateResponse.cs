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
	public class RecognizeLicensePlateResponse : AcsResponse
	{

		private string requestId;

		private RecognizeLicensePlate_Data data;

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

		public RecognizeLicensePlate_Data Data
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

		public class RecognizeLicensePlate_Data
		{

			private List<RecognizeLicensePlate_Plate> plates;

			public List<RecognizeLicensePlate_Plate> Plates
			{
				get
				{
					return plates;
				}
				set	
				{
					plates = value;
				}
			}

			public class RecognizeLicensePlate_Plate
			{

				private float? confidence;

				private string plateNumber;

				private string plateType;

				private float? plateTypeConfidence;

				private RecognizeLicensePlate_Roi roi;

				public float? Confidence
				{
					get
					{
						return confidence;
					}
					set	
					{
						confidence = value;
					}
				}

				public string PlateNumber
				{
					get
					{
						return plateNumber;
					}
					set	
					{
						plateNumber = value;
					}
				}

				public string PlateType
				{
					get
					{
						return plateType;
					}
					set	
					{
						plateType = value;
					}
				}

				public float? PlateTypeConfidence
				{
					get
					{
						return plateTypeConfidence;
					}
					set	
					{
						plateTypeConfidence = value;
					}
				}

				public RecognizeLicensePlate_Roi Roi
				{
					get
					{
						return roi;
					}
					set	
					{
						roi = value;
					}
				}

				public class RecognizeLicensePlate_Roi
				{

					private int? h;

					private int? w;

					private int? x;

					private int? y;

					public int? H
					{
						get
						{
							return h;
						}
						set	
						{
							h = value;
						}
					}

					public int? W
					{
						get
						{
							return w;
						}
						set	
						{
							w = value;
						}
					}

					public int? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public int? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}
				}
			}
		}
	}
}
