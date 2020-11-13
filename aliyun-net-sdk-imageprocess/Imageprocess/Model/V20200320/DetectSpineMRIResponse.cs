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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class DetectSpineMRIResponse : AcsResponse
	{

		private string requestId;

		private DetectSpineMRI_Data data;

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

		public DetectSpineMRI_Data Data
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

		public class DetectSpineMRI_Data
		{

			private List<DetectSpineMRI_Disc> discs;

			private List<DetectSpineMRI_Vertebra> vertebras;

			public List<DetectSpineMRI_Disc> Discs
			{
				get
				{
					return discs;
				}
				set	
				{
					discs = value;
				}
			}

			public List<DetectSpineMRI_Vertebra> Vertebras
			{
				get
				{
					return vertebras;
				}
				set	
				{
					vertebras = value;
				}
			}

			public class DetectSpineMRI_Disc
			{

				private string disease;

				private string identification;

				private List<string> location;

				public string Disease
				{
					get
					{
						return disease;
					}
					set	
					{
						disease = value;
					}
				}

				public string Identification
				{
					get
					{
						return identification;
					}
					set	
					{
						identification = value;
					}
				}

				public List<string> Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}
			}

			public class DetectSpineMRI_Vertebra
			{

				private string disease;

				private string identification;

				private List<string> location1;

				public string Disease
				{
					get
					{
						return disease;
					}
					set	
					{
						disease = value;
					}
				}

				public string Identification
				{
					get
					{
						return identification;
					}
					set	
					{
						identification = value;
					}
				}

				public List<string> Location1
				{
					get
					{
						return location1;
					}
					set	
					{
						location1 = value;
					}
				}
			}
		}
	}
}
