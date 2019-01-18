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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class CompareFaceResponse : AcsResponse
	{

		private string requestId;

		private List<CompareFace_CompareResultItem> compareResult;

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

		public List<CompareFace_CompareResultItem> CompareResult
		{
			get
			{
				return compareResult;
			}
			set	
			{
				compareResult = value;
			}
		}

		public class CompareFace_CompareResultItem
		{

			private float? similarity;

			private CompareFace_FaceA faceA;

			private CompareFace_FaceB faceB;

			public float? Similarity
			{
				get
				{
					return similarity;
				}
				set	
				{
					similarity = value;
				}
			}

			public CompareFace_FaceA FaceA
			{
				get
				{
					return faceA;
				}
				set	
				{
					faceA = value;
				}
			}

			public CompareFace_FaceB FaceB
			{
				get
				{
					return faceB;
				}
				set	
				{
					faceB = value;
				}
			}

			public class CompareFace_FaceA
			{

				private string imageUri;

				private List<string> axis;

				public string ImageUri
				{
					get
					{
						return imageUri;
					}
					set	
					{
						imageUri = value;
					}
				}

				public List<string> Axis
				{
					get
					{
						return axis;
					}
					set	
					{
						axis = value;
					}
				}
			}

			public class CompareFace_FaceB
			{

				private string imageUri;

				private List<string> axis1;

				public string ImageUri
				{
					get
					{
						return imageUri;
					}
					set	
					{
						imageUri = value;
					}
				}

				public List<string> Axis1
				{
					get
					{
						return axis1;
					}
					set	
					{
						axis1 = value;
					}
				}
			}
		}
	}
}